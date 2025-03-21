using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace Logic.Core.Networks;

// # Subnet Range formula:
// * start address = Network & mask
// * end address = (Network & mask | ~mask)
public static class CidrSubnet
{
    // GetNthSubnet
    private static readonly BigInteger IPv6MaxValue = BigInteger.Pow(2, 128) - 1;

    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size. Conpatible with terraform's `cidrsubnet(prefix, newbits, netnum)` function.
    /// </summary>
    /// <remarks>https://developer.hashicorp.com/terraform/language/functions/cidrsubnet</remarks>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string GetNthSubnet(string cidr, int newbits, int netnum) => GetNthSubnet(cidr.AsSpan(), newbits, netnum);
    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size. Conpatible with terraform's `cidrsubnet(prefix, newbits, netnum)` function.
    /// </summary>
    /// <remarks>https://developer.hashicorp.com/terraform/language/functions/cidrsubnet</remarks>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string GetNthSubnet(string cidr, int newbits, BigInteger netnum) => GetNthSubnet(cidr.AsSpan(), newbits, netnum);
    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size. Conpatible with terraform's `cidrsubnet(prefix, newbits, netnum)` function.
    /// </summary>
    /// <remarks>https://developer.hashicorp.com/terraform/language/functions/cidrsubnet</remarks>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    public static string GetNthSubnet(ReadOnlySpan<char> cidr, int newbits, int netnum) => GetNthSubnet(cidr, newbits, new BigInteger(netnum));
    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size. Conpatible with terraform's `cidrsubnet(prefix, newbits, netnum)` function.
    /// </summary>
    /// <remarks>https://developer.hashicorp.com/terraform/language/functions/cidrsubnet</remarks>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string GetNthSubnet(ReadOnlySpan<char> cidr, int newbits, BigInteger netnum)
    {
        var (ipaddress, prefixLength) = DeconstructCIDR(cidr);
        return GetNthSubnet(ipaddress, prefixLength, newbits, netnum);
    }
    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size. Conpatible with terraform's `cidrsubnet(prefix, newbits, netnum)` function.
    /// </summary>
    /// <remarks>https://developer.hashicorp.com/terraform/language/functions/cidrsubnet</remarks>
    /// <param name="ipaddress"></param>
    /// <param name="prefixLength"></param>
    /// <param name="newbits"></param>
    /// <param name="netnum"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string GetNthSubnet(IPAddress ipaddress, int prefixLength, int newbits, BigInteger netnum) => ipaddress.AddressFamily switch
    {
        AddressFamily.InterNetwork => GetNthSubnetIPv4(ipaddress, prefixLength, newbits, (int)netnum),
        AddressFamily.InterNetworkV6 => GetNthSubnetIPv6(ipaddress, prefixLength, newbits, netnum),
        _ => throw new NotImplementedException()
    };

    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size for IPv4.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static string GetNthSubnetIPv4(IPAddress ipaddress, int prefixLength, int newbits, int netnum)
    {
        var ipBytes = ipaddress.GetAddressBytes();
        var newPrefixLength = prefixLength + newbits;

        // subnetwork bit size should not exceed 32
        if (newPrefixLength > 32)
        {
            throw new ArgumentOutOfRangeException("subnetwork bit size should not exceed 32");
        }

        var shiftBits = (uint)(32 - newPrefixLength);

        // Convert big endian byte array to little endian
        Array.Reverse(ipBytes);

        // Needs little endian
        var ipValue = BitConverter.ToUInt32(ipBytes, 0);

        // Right shift original network, then Left shift for sum of original-prefix & additional-prefix, then add netnum.
        var startIpValue = (ipValue >> (int)shiftBits << (int)shiftBits) + ((uint)netnum << (int)(32 - (newPrefixLength)));
        var startIpBytes = BitConverter.GetBytes(startIpValue);

        // Convert little endian byte array back to big endian
        Array.Reverse(startIpBytes);

        var startIp = new IPAddress(startIpBytes);

        return $"{startIp}/{newPrefixLength}";
    }

    /// <summary>
    /// Get N-th subnet of a given CIDR with new bit size for IPv6.
    /// </summary>
    /// <param name="ipaddress">2001:db8::</param>
    /// <param name="prefixLength">56</param>
    /// <param name="newbits">8</param>
    /// <param name="netnum">1</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static string GetNthSubnetIPv6(IPAddress ipaddress, int prefixLength, int newbits, BigInteger netnum)
    {
        var newPrefixLength = prefixLength + newbits;
        // If subnets are too small to split, throw an exception.
        if (newPrefixLength > 128)
        {
            throw new ArgumentOutOfRangeException(nameof(newbits), "Subnet size is too large.");
        }

        // Convert the network address to a BigInteger representation.
        var networkNumber = IpToNumber(ipaddress, prefixLength);

        // Calculate the mask for new subnet range.
        var mask = BigInteger.One << (128 - prefixLength - newbits);

        // Calculate the start of the new subnet.
        var newNetworkNumber = (networkNumber & (~(mask - 1))) + (mask * netnum);

        // If the new subnet falls out of the IPv6 range, throw an exception.
        if (newNetworkNumber > IPv6MaxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(netnum), "Subnet does not fit in IPv6 address space.");
        }

        // Convert the BigInteger back to an IPAddress object.
        var newNetwork = NumberToIp(newNetworkNumber);

        // Create subnet string in CIDR format.
        return $"{newNetwork}/{newPrefixLength}";

        // Convert an IPAddress to a BigInteger
        static BigInteger IpToNumber(IPAddress ip, int prefixLength)
        {
            var bytes = ip.GetAddressBytes();

            // Reverse the bytes if the system architecture is Little Endian.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            // Create a BigInteger from the byte array and normalize it.
            // The IPAddress's byte array is reversed if the system uses little endian byte order,
            // as BigInteger expects an array in little endian order.
            //
            // An extra 0-byte is prefixed to force the interpretation of the byte array as a positive number
            // ensuring compatibility across different platforms, as the BigInteger constructor assumes a 
            // 2's complement representation when the byte array is passed, and the most significant bit 
            // is used to denote whether the number is positive or negative.
            var num = new BigInteger(bytes.Concat(new byte[] { 0 }).ToArray());

            // Normalize the BigInteger representation to remove any 'spill over' between zones.
            return num >> (128 - prefixLength) << (128 - prefixLength);
        }

        // Convert a BigInteger to an IPAddress
        //
        // The BigInteger's byte array is reversed if the system uses little endian byte order,
        // as BigInteger produces an array in little endian order.
        static IPAddress NumberToIp(BigInteger number)
        {
            // The BigInteger's byte array is reversed if the system uses little endian byte order,
            // as BigInteger produces an array in little endian order.
            //
            // GetByteArray will range from 1 to 17 bytes, AsSpan(..16) ensures the array is of length 16.
            // This is required as GetBytes can return a variable length array.
            return new IPAddress(number.ToByteArray(isUnsigned: true, isBigEndian: true).AsSpan(0, 16));
        }
    }

    // GetSubnetRange

    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(string cidr) => GetSubnetRangeSlow(cidr.AsSpan());
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(ReadOnlySpan<char> cidr)
    {
        var (address, subnet) = DeconstructCIDR(cidr);
        return GetSubnetRangeSlow(address, subnet);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(string ipaddress, int prefixLength) => GetSubnetRangeSlow(ipaddress.AsSpan(), prefixLength);
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(ReadOnlySpan<char> ipaddress, int prefixLength) => GetSubnetRangeSlow(IPAddress.Parse(ipaddress), prefixLength);
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(IPAddress ipaddress, int prefixLength)
    {
        if (ipaddress.AddressFamily == AddressFamily.InterNetwork && (prefixLength < 1 || prefixLength > 32))
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv4 space.");
        }
        ;
        if (ipaddress.AddressFamily == AddressFamily.InterNetworkV6 && (prefixLength < 1 || prefixLength > 128))
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv6 space.");
        }
        ;

        // BigInteger can handle IPv6 range.
        var bytes = ipaddress.GetAddressBytes();

        // get bit for subnetmask.
        var addressBits = bytes.Length * 8;
        var maskBits = (BigInteger.One << (addressBits - prefixLength)) - 1;

        // get bigInteger ip.
        var ip = new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
        var startAddrBytes = ip & ~maskBits;
        var endAddrBytes = ip | maskBits;

        // convert BigInteger IP to IPAddress
        Span<byte> firstAddressBytes = stackalloc byte[bytes.Length];
        startAddrBytes.TryWriteBytes(firstAddressBytes, out _, true, true);

        Span<byte> lastAddressBytes = stackalloc byte[bytes.Length];
        endAddrBytes.TryWriteBytes(lastAddressBytes, out _, true, true);

        return (new IPAddress(firstAddressBytes), new IPAddress(lastAddressBytes));
    }

    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(string cidr) => GetSubnetRange(cidr.AsSpan());
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(ReadOnlySpan<char> cidr)
    {
        var (address, prefixLength) = DeconstructCIDR(cidr);
        return GetSubnetRange(address, prefixLength);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(string ipaddress, int prefixLength)
    {
        return GetSubnetRange(IPAddress.Parse(ipaddress), prefixLength);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(IPAddress ipaddress, int prefixLength) => ipaddress.AddressFamily switch
    {
        AddressFamily.InterNetwork => GetSubnetRangeIPv4(ipaddress, prefixLength),
        AddressFamily.InterNetworkV6 => GetSubnetRangeIPv6(ipaddress, prefixLength),
        _ => throw new NotImplementedException()
    };

    /// <summary>
    /// Calculate SubnetRange for IPv4 by mask & shift operation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    private static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeIPv4(IPAddress ipaddress, int prefixLength)
    {
        if (prefixLength < 1 || prefixLength > 32)
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv4 space.");
        }
        ;

        var bytes = ipaddress.GetAddressBytes();

        // get uint bit for subnetmask.
        uint maskBits = 0xffffffff;
        maskBits <<= (32 - prefixLength);

        // get uint ipaddress
        var ip = (Convert.ToUInt32(bytes[0]) << 24)
            | (Convert.ToUInt32(bytes[1]) << 16)
            | (Convert.ToUInt32(bytes[2]) << 8)
            | (Convert.ToUInt32(bytes[3]));
        var startAddrBytes = ip & maskBits;
        var endAddrBytes = ip | ~maskBits;

        // convert LittleEndian uint IP to IPAddress
        var firstAddressBytes = GetBigEndianBytes(startAddrBytes);
        var lastAddressBytes = GetBigEndianBytes(endAddrBytes);

        return (new IPAddress(firstAddressBytes), new IPAddress(lastAddressBytes));

        // littleEndian -> bigendien
        static Span<byte> GetBigEndianBytes(uint addressBytes)
            => BitConverter.GetBytes((addressBytes & 0x000000FFU) << 24 | (addressBytes & 0x0000FF00U) << 8 | (addressBytes & 0x00FF0000U) >> 8 | (addressBytes & 0xFF000000U) >> 24);
    }

    /// <summary>
    /// Calculate SubnetRange for IPv6 by mask & shift operation.
    /// </summary>
    /// <param name="ipaddress">2001:db8::</param>
    /// <param name="prefixLength">56</param>
    /// <returns></returns>
    private static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeIPv6(IPAddress ipaddress, int prefixLength)
    {
        if (prefixLength < 1 || prefixLength > 128)
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv6 space.");
        }
        ;

        var fullPrefixBytes = prefixLength / 8;
        var remainingBitsInByte = prefixLength % 8; // could be 0

        // First address is obtained be setting all bits outside prefix to 0
        Span<byte> firstAddressBytes = stackalloc byte[16];
        ipaddress.TryWriteBytes(firstAddressBytes, out var _);
        if (remainingBitsInByte > 0)
        {
            firstAddressBytes[fullPrefixBytes] &= (byte)(0xFF << (8 - remainingBitsInByte));
            for (var i = fullPrefixBytes + 1; i < firstAddressBytes.Length; i++)
            {
                firstAddressBytes[i] = 0;
            }
        }
        else if (fullPrefixBytes < firstAddressBytes.Length)
        {
            for (var i = fullPrefixBytes; i < firstAddressBytes.Length; i++)
            {
                firstAddressBytes[i] = 0;
            }
        }

        // Last address is obtained by setting all bits outside prefix to 1
        Span<byte> lastAddressBytes = stackalloc byte[16];
        firstAddressBytes.CopyTo(lastAddressBytes);
        // if there is an incomplete byte in prefix, set the remaining bits to 1
        if (remainingBitsInByte > 0)
        {
            lastAddressBytes[prefixLength / 8] |= (byte)(0xFF >> remainingBitsInByte);
        }
        // set all bytes after the prefix to 1
        for (var i = (prefixLength + 7) / 8; i < lastAddressBytes.Length; i++)
        {
            lastAddressBytes[i] = 0xFF;
        }

        return (new IPAddress(firstAddressBytes), new IPAddress(lastAddressBytes));
    }

    private static (IPAddress IPAddress, int PrefixLength) DeconstructCIDR(ReadOnlySpan<char> span)
    {
        var index = span.IndexOf('/');
        var ipSpan = span[..index];
        var subnetSpan = span[(index + 1)..];
        return (IPAddress.Parse(ipSpan), int.Parse(subnetSpan));
    }
}
