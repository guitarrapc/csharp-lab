using System.Buffers.Binary;
using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace Logic.Core.Networks;

public static class CidrAggregatorv4
{
    /// <summary>
    /// Aggregates a list of CIDR blocks into the smallest possible list of CIDR blocks. Return snapshot of the aggregated list.
    /// </summary>
    /// <param name="cidrs">IPv4 CIDRs. e.g., 192.168.0.0/24</param>
    /// <returns></returns>
    public static IReadOnlyList<string> Aggregate(IEnumerable<string> cidrs)
    {
        // Convert each CIDR to an IPRange and sort by Start address.
        var ranges = cidrs
            .Select(cidr => ParseCIDR(cidr))
            .OrderBy(r => r.Start)
            .ToList();

        if (ranges.Count == 0)
            return [];

        // Merge overlapping or contiguous ranges.
        var mergedRanges = new List<IPRange>(ranges.Count);
        var current = ranges[0];
        for (int i = 1; i < ranges.Count; i++)
        {
            if (current.End + 1 >= ranges[i].Start)
            {
                // Merge if adjacent or overlapping.
                current.End = Math.Max(current.End, ranges[i].End);
            }
            else
            {
                mergedRanges.Add(current);
                current = ranges[i];
            }
        }
        mergedRanges.Add(current);

        // Convert each merged range back into a minimal list of CIDR blocks.
        var resultCIDRs = new List<string>(mergedRanges.Count);
        foreach (var range in mergedRanges)
        {
            resultCIDRs.AddRange(RangeToCIDRs(range.Start, range.End));
        }

        return resultCIDRs;
    }

    /// <summary>
    /// Parses a CIDR string (e.g., "192.168.0.0/24") into an IPRange.
    /// </summary>
    /// <param name="cidr"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static IPRange ParseCIDR(string cidr)
    {
        var parts = cidr.Split('/');
        if (parts.Length != 2)
            throw new ArgumentException("Invalid CIDR format: " + cidr);

        var ip = IPAddress.Parse(parts[0]);
        
        // Validate IPv4
        if (ip.AddressFamily != AddressFamily.InterNetwork)
            throw new ArgumentException("Only IPv4 addresses are supported: " + cidr);
        
        if (!int.TryParse(parts[1], out var prefix) || prefix < 0 || prefix > 32)
            throw new ArgumentException("Invalid prefix length (must be 0-32): " + cidr);

        uint ipUint = IPToUint(ip);
        uint mask = prefix == 0 ? 0 : 0xFFFFFFFF << (32 - prefix);
        uint network = ipUint & mask;
        uint broadcast = network | ~mask;

        return new IPRange { Start = network, End = broadcast };
    }

    /// <summary>
    /// Converts an IPAddress to a 32-bit unsigned integer in network byte order (big-endian).
    /// The returned value can be used for bitwise operations and comparisons.
    /// </summary>
    /// <param name="ip">IPv4 address to convert</param>
    /// <returns>32-bit unsigned integer representation in network byte order</returns>
    /// <exception cref="InvalidOperationException">Failed to write IP address bytes</exception>
    private static uint IPToUint(IPAddress ip)
    {
        Span<byte> bytes = stackalloc byte[4];
        if (!ip.TryWriteBytes(bytes, out _))
            throw new InvalidOperationException("Failed to write IP address bytes.");

        // IPAddress.TryWriteBytes writes in network byte order (big-endian).
        // Read as big-endian uint for consistent bitwise operations.
        return BinaryPrimitives.ReadUInt32BigEndian(bytes);
    }

    /// <summary>
    /// Converts a 32-bit unsigned integer in network byte order (big-endian) to an IPAddress.
    /// </summary>
    /// <param name="ipUint">32-bit unsigned integer in network byte order</param>
    /// <returns>IPAddress object</returns>
    private static IPAddress UintToIP(uint ipUint)
    {
        Span<byte> bytes = stackalloc byte[4];

        // Write uint as big-endian to match network byte order expected by IPAddress.
        BinaryPrimitives.WriteUInt32BigEndian(bytes, ipUint);

        return new IPAddress(bytes);
    }

    /// <summary>
    /// Converts a given IP range (from start to end) into a minimal list of CIDR blocks.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    private static List<string> RangeToCIDRs(uint start, uint end)
    {
        var result = new List<string>();
        while (start <= end)
        {
            // Determine the maximum prefix length based on start address alignment.
            // Count trailing zeros to find the largest power-of-2 block that starts at 'start'.
            byte maxPrefixFromAlignment = start == 0 
                ? (byte)0 
                : (byte)(32 - BitOperations.TrailingZeroCount(start));

            // Calculate the maximum prefix based on the remaining address count.
            // Special case: if start is 0 and end is uint.MaxValue, we have the entire IPv4 space
            byte maxPrefixFromRange;
            if (start == 0 && end == uint.MaxValue)
            {
                maxPrefixFromRange = 0;
            }
            else
            {
                uint remaining = end - start + 1;

                // Find the smallest prefix that can fit within the remaining addresses.
                // BitOperations.Log2 returns the floor of log2, which works for both power-of-2 and non-power-of-2 values.
                // note: We should avoid using Math.Log2() or Math.Floor(Math.Log()) to prevent floating-point inaccuracies.
                maxPrefixFromRange = (byte)(32 - BitOperations.Log2(remaining));
            }

            // Choose the more restrictive (larger) prefix.
            byte prefix = Math.Max(maxPrefixFromAlignment, maxPrefixFromRange);

            // Generate the CIDR block.
            var cidr = $"{UintToIP(start)}/{prefix}";
            result.Add(cidr);

            // Move to the next block's start address.
            // Handle overflow: if prefix is 0, we're done (covers entire IPv4 space).
            if (prefix == 0)
                break;
                
            uint blockSize = 1u << (32 - prefix);
            
            // Check for overflow before adding
            if (start > uint.MaxValue - blockSize)
                break;
                
            start += blockSize;
        }
        return result;
    }

    // Represents an IPv4 address range.
    private struct IPRange
    {
        public uint Start;
        public uint End;
    }
}
