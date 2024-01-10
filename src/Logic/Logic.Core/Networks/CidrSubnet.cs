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
    /// <param name="ipaddress"></param>
    /// <param name="subnetBits"></param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange(string ipaddress, int subnetBits)
    {
        var address = IPAddress.Parse(ipaddress);
        return CalculateSubnetRange(address, subnetBits);
    }

    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange(IPAddress ipaddress, int subnetBits)
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
        Span<byte> startSpan = stackalloc byte[bytes.Length];
        startAddrBytes.TryWriteBytes(startSpan, out _, true, true);
        var startAddress = new IPAddress(startSpan);

        Span<byte> endSpan = stackalloc byte[bytes.Length];
        endAddrBytes.TryWriteBytes(endSpan, out _, true, true);
        var endAddress = new IPAddress(endSpan);

        return (startAddress, endAddress);
    }

    /// <summary>
    /// Calculate SubnetRange for both IPv4 and IPv6 with byte shift implementation.
    /// </summary>
    /// <param name="ipaddress"></param>
    /// <param name="subnetBits"></param>
    /// <returns></returns>
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange2(string ipaddress, int subnetBits)
    {
        return CalculateSubnetRange2(IPAddress.Parse(ipaddress), subnetBits);
    }
    public static (IPAddress StartAddress, IPAddress EndAddress) CalculateSubnetRange2(IPAddress ipaddress, int subnetBits)
    {
        return ipaddress.AddressFamily switch
        {
            AddressFamily.InterNetwork => CalculateIPv4SubnetRange(ipaddress, subnetBits),
            AddressFamily.InterNetworkV6 => CalculateIPv6SubnetRange(ipaddress, subnetBits),
            _ => throw new NotImplementedException()
        };
    }

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
        var startBytes = GetBigEndianBytes(startAddrBytes);
        var startAddress = new IPAddress(startBytes);

        var endBytes = GetBigEndianBytes(endAddrBytes);
        var endAddress = new IPAddress(endBytes);

        return (startAddress, endAddress);

        // littleEndian -> bigendien
        static Span<byte> GetBigEndianBytes(uint addressBytes)
            => BitConverter.GetBytes((addressBytes & 0x000000FFU) << 24 | (addressBytes & 0x0000FF00U) << 8 | (addressBytes & 0x00FF0000U) >> 8 | (addressBytes & 0xFF000000U) >> 24);
    }

    private static (IPAddress StartAddress, IPAddress EndAddress) CalculateIPv6SubnetRange(IPAddress ipaddress, int subnetBits)
    {
        var bytes = ipaddress.GetAddressBytes();

        // get int bit for subnetmask.
        var maskBits = 128 - subnetBits;

        // サブネットで指定した下位ビット(サブネット64なら8ビット)を0にする
        for (var i = 0; i < maskBits / 8; i++)
        {
            bytes[15 - i] &= 0x00;
        }
        // サブネットが8ビット単位じゃない場合、余りを0にする
        if (maskBits % 8 != 0)
        {
            bytes[15 - (maskBits / 8)] &= (byte)~(0xFF >> (maskBits % 8));
        }
        var startAddress = new IPAddress(bytes);

        // TODO: 32 などにしたときにendAddressの計算がおかしい。64では問題ない。
        // 終了アドレスを計算。サブネットで指定した下位ビット(サブネット64なら8ビット)の最終値を割り当てる
        for (int i = 0; i < subnetBits / 8; i++)
        {
            bytes[15 - i] |= 0xFF;
        }
        // サブネットが8ビット単位じゃない場合、余りを最終値にする
        if (subnetBits % 8 != 0)
        {
            bytes[15 - (subnetBits / 8)] |= (byte)(0xFF >> (8 - (subnetBits % 8)));
        }
        var endAddress = new IPAddress(bytes);

        return (startAddress, endAddress);
    }
}
