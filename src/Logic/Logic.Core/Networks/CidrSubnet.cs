using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace Logic.Networks;

// # Subnet Range formula:
// * start address = Network & mask
// * end address = (Network & mask | ~mask)
public static class CidrSubnet
{
    // GetSubnetRange

    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(string cidr)
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
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeSlow(string ipaddress, int prefixLength)
    {
        var address = IPAddress.Parse(ipaddress);
        return GetSubnetRangeSlow(address, prefixLength);
    }
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
        };
        if (ipaddress.AddressFamily == AddressFamily.InterNetworkV6 && (prefixLength < 1 || prefixLength > 128))
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv6 space.");
        };

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
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(string cidr)
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
    public static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRange(IPAddress ipaddress, int prefixLength)
    {
        return ipaddress.AddressFamily switch
        {
            AddressFamily.InterNetwork => GetSubnetRangeIPv4(ipaddress, prefixLength),
            AddressFamily.InterNetworkV6 => GetSubnetRangeIPv6(ipaddress, prefixLength),
            _ => throw new NotImplementedException()
        };
    }

    /// <summary>
    /// Calculate SubnetRange for IPv4 by mask & shift operation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="prefixLength">24</param>
    /// <returns></returns>
    private static (IPAddress StartAddress, IPAddress EndAddress) GetSubnetRangeIPv4(IPAddress ipaddress, int prefixLength)
    {
        if (ipaddress.AddressFamily == AddressFamily.InterNetwork && (prefixLength < 1 || prefixLength > 32))
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv4 space.");
        };

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
        if (ipaddress.AddressFamily == AddressFamily.InterNetworkV6 && (prefixLength < 1 || prefixLength > 128))
        {
            throw new ArgumentOutOfRangeException(nameof(prefixLength), "Subnet does not fit in IPv6 space.");
        };

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

    private static (IPAddress IPAddress, int PrefixLength) DeconstructCIDR(string cidr)
    {
        ReadOnlySpan<char> span = cidr.AsSpan();
        var index = span.IndexOf('/');
        var ipSpan = span[..index];
        var ip = IPAddress.Parse(ipSpan);
        var subnetSpan = span[(index + 1)..];
        var prefixLength = int.Parse(subnetSpan);

        return (ip, prefixLength);
    }
}
