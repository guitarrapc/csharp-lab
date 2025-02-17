﻿using System.Net;

namespace Logic.Core.Networks;

/// <summary>
/// Create Subnetmask for CIDR, IPAddress, Notion.
/// </summary>
public readonly struct SubnetMaskv4 : IEquatable<SubnetMaskv4>
{
    const int bitLength = 8;

    public ReadOnlySpan<byte> ByteArray => _byteArray;
    private readonly byte[] _byteArray = new byte[bitLength * 4];

    public SubnetMaskv4(ReadOnlySpan<byte> byteArray)
    {
        byteArray.CopyTo(_byteArray);
    }

    /// <summary>
    /// Calculate Subnetmask from prefix. Useful for calculate from subnet.
    /// </summary>
    /// <param name="bit"></param>
    /// <returns></returns>
    /// <example>
    /// 24:          11111111 11111111 11111111 00000000
    /// 8:           11111111 00000000 00000000 00000000
    /// </example>
    public static SubnetMaskv4 FromPrefix(byte bit)
    {
        if (bit > bitLength * 4)
        {
            throw new ArgumentOutOfRangeException("Input bit must be lower than 32.");
        }

        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        for (var i = 0; i < bit; i++)
        {
            byteArray[i] = 1;
        }
        return new SubnetMaskv4(byteArray);
    }

    /// <summary>
    /// Calculate Subnetmask from IPAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. 10.0.0.0</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0: 11000000 10101000 00000000 00000000
    /// 10.1.0.0:    00001010 00000001 00000000 00000000
    /// </example>
    public static SubnetMaskv4 FromIPAddress(IPAddress ipAddress)
    {
        var address = ipAddress.GetAddressBytes();
        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        SetBinaryArray(byteArray, address[0], 1);
        SetBinaryArray(byteArray, address[1], 2);
        SetBinaryArray(byteArray, address[2], 3);
        SetBinaryArray(byteArray, address[3], 4);
        return new SubnetMaskv4(byteArray);
    }
    /// <summary>
    /// Calculate Subnetmask from IPAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0: 11000000 10101000 00000000 00000000
    /// 10.1.0.0:    00001010 00000001 00000000 00000000
    /// </example>
    public static SubnetMaskv4 FromIPAddress(string ipAddress) => FromIPAddress(ipAddress.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from IPAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0: 11000000 10101000 00000000 00000000
    /// 10.1.0.0:    00001010 00000001 00000000 00000000
    /// </example>
    public static SubnetMaskv4 FromIPAddress(ReadOnlySpan<char> ipAddress)
    {
        ReadOnlySpan<char> rest = ipAddress;
        var oct1End = rest.IndexOf('.');
        if (oct1End == -1) throw new FormatException($"{nameof(ipAddress)} is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx'.");
        var oct1 = rest[..oct1End];
        rest = rest[(oct1End + 1)..];

        var oct2End = rest.IndexOf('.');
        if (oct2End == -1) throw new FormatException($"{nameof(ipAddress)} is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx'.");
        var oct2 = rest[..oct2End];
        rest = rest[(oct2End + 1)..];

        var oct3End = rest.IndexOf('.');
        if (oct3End == -1) throw new FormatException($"{nameof(ipAddress)} is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx'.");
        var oct3 = rest[..oct3End];
        rest = rest[(oct3End + 1)..];

        var oct4End = rest.IndexOf('.');
        if (oct4End != -1 || rest.Length > 3)
        {
            // -1 = contains "."
            // >3 = larger then 1000
            throw new FormatException($"{nameof(ipAddress)}  is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
        }
        var oct4 = rest;

        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        SetBinaryArray(byteArray, byte.Parse(oct1), 1);
        SetBinaryArray(byteArray, byte.Parse(oct2), 2);
        SetBinaryArray(byteArray, byte.Parse(oct3), 3);
        SetBinaryArray(byteArray, byte.Parse(oct4), 4);
        return new SubnetMaskv4(byteArray);
    }
    private static void SetBinaryArray(Span<byte> byteArray, byte octed, int loop)
    {
        var position = bitLength * loop - 1;
        var number = octed;
        for (var j = bitLength - 1; j >= 0; j--)
        {
            byteArray[position] = Convert.ToByte(number & (2 - 1)); // n % m == n & (m - 1)
            number = Convert.ToByte(number / 2);
            position--;
        }
    }

    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="cidrAddress">CidrAddress. Format like 10.0.0.0/24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0/32: (11000000 10101000 00000000 00000000, 11111111 11111111 11111111 00000000)
    /// 10.1.0.0/8:    (00001010 00000001 00000000 00000000, 11111111 00000000 00000000 00000000)
    /// </example>
    public static (SubnetMaskv4 Address, SubnetMaskv4 Subnet) FromCidr(string cidrAddress) => FromCidr(cidrAddress.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="cidrAddress">CidrAddress. Format like 10.0.0.0/24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0/32: (11000000 10101000 00000000 00000000, 11111111 11111111 11111111 00000000)
    /// 10.1.0.0/8:    (00001010 00000001 00000000 00000000, 11111111 00000000 00000000 00000000)
    /// </example>
    public static (SubnetMaskv4 Address, SubnetMaskv4 Subnet) FromCidr(ReadOnlySpan<char> cidrAddress)
    {
        var index = cidrAddress.IndexOf('/');
        var cidr = cidrAddress[..index];
        var subnet = cidrAddress[(index + 1)..];
        return FromCidr(cidr, subnet);
    }
    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0, 32: (11000000 10101000 00000000 00000000, 11111111 11111111 11111111 00000000)
    /// 10.1.0.0, 8:    (00001010 00000001 00000000 00000000, 11111111 00000000 00000000 00000000)
    /// </example>
    public static (SubnetMaskv4 Address, SubnetMaskv4 Subnet) FromCidr(string ipAddress, string subnetmask) => FromCidr(ipAddress.AsSpan(), subnetmask.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.0.0, 32: (11000000 10101000 00000000 00000000, 11111111 11111111 11111111 00000000)
    /// 10.1.0.0, 8:    (00001010 00000001 00000000 00000000, 11111111 00000000 00000000 00000000)
    /// </example>
    public static (SubnetMaskv4 Address, SubnetMaskv4 Subnet) FromCidr(ReadOnlySpan<char> ipAddress, ReadOnlySpan<char> subnetmask)
    {
        return (FromIPAddress(ipAddress), FromPrefix(byte.Parse(subnetmask)));
    }

    /// <summary>
    /// Calculate Networkmask.
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.10.10/24: 192.168.10.0
    /// 11000000 10101000 00001010 00001010, 11111111 11111111 11111111 00000000 : 11000000 10101000 00001010 00000000
    /// </example>
    public static SubnetMaskv4 GetNetworkAddress(string cidrAddress)
    {
        var (address, subnetmask) = FromCidr(cidrAddress);
        return GetNetworkAddress(address, subnetmask);
    }
    /// <summary>
    /// Calculate Networkmask.
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.10.10/24                                                         : 192.168.10.0
    /// 11000000 10101000 00001010 00001010, 11111111 11111111 11111111 00000000 : 11000000 10101000 00001010 00000000
    /// </example>
    public static SubnetMaskv4 GetNetworkAddress(SubnetMaskv4 ipAddress, SubnetMaskv4 subnetmask)
    {
        Span<byte> networkmask = stackalloc byte[32];
        for (var i = 0; i < 32; i++)
        {
            networkmask[i] = (byte)(ipAddress.ByteArray[i] & subnetmask.ByteArray[i]);
        }
        return new SubnetMaskv4(networkmask);
    }

    /// <summary>
    /// Calculate Network Range for the NetworkAddress.
    /// </summary>
    /// <param name="networkAddress">Network Address, Not IPAddress. format like 192.168.0.0</param>
    /// <param name="subnetmask">Subnetmask string. Format like 24</param>
    /// <returns></returns>
    /// <example>
    /// 192.168.10.10/24
    /// 11000000 10101000 00001010 00001010, 11111111 11111111 11111111 00000000
    /// 
    /// BroadcastAddress: 192.168.10.255
    /// FirstAddress    : 192.168.10.0
    /// EndAddress      : 192.168.10.255
    /// </example>
    public static (SubnetMaskv4 BroadcastAddress, SubnetMaskv4 FirstAddress, SubnetMaskv4 EndAddress) GetAddressRange(SubnetMaskv4 networkAddress, SubnetMaskv4 subnetmask)
    {
        Span<byte> broadcastAddress = stackalloc byte[32];
        Span<byte> rangeFirstAddress = stackalloc byte[32];
        Span<byte> rangeLastAddress = stackalloc byte[32];
        for (var i = 0; i < 32; i++)
        {
            broadcastAddress[i] = subnetmask.ByteArray[i] == 1 ? networkAddress.ByteArray[i] : (byte)1;
            if (subnetmask.ByteArray[i] == 1)
            {
                rangeFirstAddress[i] = networkAddress.ByteArray[i];
                rangeLastAddress[i] = networkAddress.ByteArray[i];
            }
            else if (i == 31)
            {
                rangeFirstAddress[i] = 0;
                rangeLastAddress[i] = 1;
            }
            else
            {
                rangeFirstAddress[i] = networkAddress.ByteArray[i];
                rangeLastAddress[i] = 1;
            }
        }

        return (new SubnetMaskv4(broadcastAddress), new SubnetMaskv4(rangeFirstAddress), new SubnetMaskv4(rangeLastAddress));
    }

    // 8
    public byte ToPrefix()
    {
        byte bit = 0;
        for (var i = 0; i < _byteArray.Length - 1; i++)
        {
            if (_byteArray[i] <= 0 || _byteArray[i] > 1) break;
            bit++;
        }
        return bit;
    }

    // 11111111 00000000 00000000 00000000 -> 255.0.0.0
    public override string ToString()
    {

        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        var octet1 = GetOctet(_byteArray.AsSpan()[..bitLength]);
        var octet2 = GetOctet(_byteArray.AsSpan()[bitLength..(bitLength * 2)]);
        var octet3 = GetOctet(_byteArray.AsSpan()[(bitLength * 2)..(bitLength * 3)]);
        var octet4 = GetOctet(_byteArray.AsSpan()[(bitLength * 3)..(bitLength * 4)]);
        return $"{octet1}.{octet2}.{octet3}.{octet4}";
    }

    private static byte GetOctet(ReadOnlySpan<byte> octet)
    {
        int subnet = 0;
        for (var i = 0; i <= octet.Length - 1; i++)
        {
            subnet += octet[i] * (byte)Math.Pow(2, (bitLength - 1) - i);
        }
        return (byte)subnet;
    }

    public override bool Equals(object? obj)
    {
        return obj is SubnetMaskv4 mask && Equals(mask);
    }

    public bool Equals(SubnetMaskv4 other)
    {
        ReadOnlySpan<byte> l = ByteArray;
        ReadOnlySpan<byte> r = other.ByteArray;
        return l.SequenceEqual(r);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_byteArray);
    }

    public static bool operator ==(SubnetMaskv4 left, SubnetMaskv4 right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SubnetMaskv4 left, SubnetMaskv4 right)
    {
        return !(left == right);
    }
}
