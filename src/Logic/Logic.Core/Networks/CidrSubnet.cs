using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace Logic.Networks;
public static class CidrSubnet
{
    // How to calculate SubnetRange
    // * start address = Network & mask
    // * end address = (Network & mask | ~mask)

    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="cidr">192.168.0.1/24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRangeSlow(string cidr)
    {
        var (address, subnet) = DeconstructCIDR(cidr);
        return CalculateSubnetRangeSlow(address, subnet);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="subnetBits">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRangeSlow(string ipaddress, int subnetBits)
    {
        var address = IPAddress.Parse(ipaddress);
        return CalculateSubnetRangeSlow(address, subnetBits);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with BigInteger.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="subnetBits">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRangeSlow(IPAddress ipaddress, int subnetBits)
    { 
        // BigInteger can handle IPv6 range.
        var bytes = ipaddress.GetAddressBytes();

        // get bit for subnetmask.
        var addressBits = bytes.Length * 8;
        var maskBits = (BigInteger.One << (addressBits - subnetBits)) - 1;

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
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange(string cidr)
    {
        var (address, subnet) = DeconstructCIDR(cidr);
        return CalculateSubnetRange(address, subnet);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="subnetBits">24</param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange(string ipaddress, int subnetBits)
    {
        return CalculateSubnetRange(IPAddress.Parse(ipaddress), subnetBits);
    }
    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="subnetBits">24</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange(IPAddress ipaddress, int subnetBits)
    {
        return ipaddress.AddressFamily switch
        {
            AddressFamily.InterNetwork => CalculateIPv4SubnetRange(ipaddress, subnetBits),
            AddressFamily.InterNetworkV6 => CalculateIPv6SubnetRange(ipaddress, subnetBits),
            _ => throw new NotImplementedException()
        };
    }

    /// <summary>
    /// Calculate SubnetRange for IPv4 by mask & shift operation.
    /// </summary>
    /// <param name="ipaddress">192.168.0.1</param>
    /// <param name="subnetBits">24</param>
    /// <returns></returns>
    private static (IPAddress StartAddress, IPAddress EndAddress) CalculateIPv4SubnetRange(IPAddress ipaddress, int subnetBits)
    {
        var bytes = ipaddress.GetAddressBytes();

        // get uint bit for subnetmask.
        uint maskBits = 0xffffffff;
        maskBits <<= (32 - subnetBits);

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
    /// <param name="prefix">56</param>
    /// <returns></returns>
    private static (IPAddress StartAddress, IPAddress EndAddress) CalculateIPv6SubnetRange(IPAddress ipaddress, int prefix)
    {
        var fullPrefixBytes = prefix / 8;
        var remainingBitsInByte = prefix % 8; // could be 0

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
            lastAddressBytes[prefix / 8] |= (byte)(0xFF >> remainingBitsInByte);
        }
        // set all bytes after the prefix to 1
        for (var i = (prefix + 7) / 8; i < lastAddressBytes.Length; i++)
        {
            lastAddressBytes[i] = 0xFF;
        }

        return (new IPAddress(firstAddressBytes), new IPAddress(lastAddressBytes));
    }

    private static (IPAddress IPAddress, int Subnet) DeconstructCIDR(string ipaddress)
    {
        ReadOnlySpan<char> span = ipaddress.AsSpan();
        var index = span.IndexOf('/');
        var ipSpan = span.Slice(0, index);
        var ip = IPAddress.Parse(ipSpan);
        var subnetSpan = span.Slice(index + 1, span.Length - (index + 1));
        var subnet = int.Parse(subnetSpan);

        return (ip, subnet);
    }
}
