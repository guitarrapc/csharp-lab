using System.Net;
using System.Runtime.InteropServices;

namespace Logic.Core.Networks;

public static class CidrMergerv4
{
    /// <summary>
    /// Aggregates a list of CIDR blocks into the smallest possible list of CIDR blocks.
    /// </summary>
    /// <param name="cidrs">IPv4 CIDRs. e.g., 192.168.0.0/24</param>
    /// <returns></returns>
    public static List<string> Aggregate(IEnumerable<string> cidrs)
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
        var prefix = int.Parse(parts[1]);

        uint ipUint = IPToUint(ip);
        uint mask = prefix == 0 ? 0 : 0xFFFFFFFF << (32 - prefix);
        uint network = ipUint & mask;
        uint broadcast = network | ~mask;

        return new IPRange { Start = network, End = broadcast };
    }

    /// <summary>
    /// Converts an IPAddress to a 32-bit unsigned integer using Span.
    /// </summary>
    /// <param name="ip"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    private static uint IPToUint(IPAddress ip)
    {
        Span<byte> bytes = stackalloc byte[4];
        if (!ip.TryWriteBytes(bytes, out _))
            throw new InvalidOperationException("Failed to write IP address bytes.");
        // Ensure big-endian for network order
        if (BitConverter.IsLittleEndian)
            bytes.Reverse();
        return MemoryMarshal.Read<uint>(bytes);
    }

    /// <summary>
    /// Converts a 32-bit unsigned integer to an IPAddress using Span.
    /// </summary>
    /// <param name="ipUint"></param>
    /// <returns></returns>
    private static IPAddress UintToIP(uint ipUint)
    {
        Span<byte> bytes = stackalloc byte[4];
        MemoryMarshal.Write(bytes, in ipUint);
        if (BitConverter.IsLittleEndian)
            bytes.Reverse();
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
            // Determine the maximum prefix allowed by the current start address alignment.
            byte alignmentPrefix = 32;
            while (alignmentPrefix > 0)
            {
                uint mask = 0xFFFFFFFF << (32 - alignmentPrefix);
                if ((start & mask) != start)
                    break;
                alignmentPrefix--;
            }
            alignmentPrefix++;

            // Calculate the maximum prefix based on the remaining address count.
            uint remaining = end - start + 1;
            byte maxPrefixBasedOnRange = (byte)(32 - Math.Floor(Math.Log(remaining, 2)));

            // Choose the more restrictive prefix.
            byte prefix = Math.Max(alignmentPrefix, maxPrefixBasedOnRange);

            // Generate the CIDR block.
            var cidr = $"{UintToIP(start)}/{prefix}";
            result.Add(cidr);

            // Move to the next block's start address.
            uint blockSize = (uint)Math.Pow(2, 32 - prefix);
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
