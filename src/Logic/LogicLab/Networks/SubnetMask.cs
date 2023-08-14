namespace LogicLab.Networks;

public readonly struct SubnetMask : IEquatable<SubnetMask>
{
    const int bitLength = 8;

    // 11111111 00000000 00000000 00000000
    public ReadOnlySpan<byte> ByteArray => _byteArray;
    private readonly byte[] _byteArray;

    public SubnetMask(ReadOnlySpan<byte> byteArray)
    {
        _byteArray = byteArray.ToArray();
    }

    /// <summary>
    /// Calculate Subnetmask from bit. Useful for calculate from subnet.
    /// </summary>
    /// <param name="bit"></param>
    /// <returns></returns>
    public static SubnetMask FromCidrNotion(byte bit)
    {
        if (bit > bitLength * 4) throw new ArgumentOutOfRangeException("Input bit must be lower than 32.");

        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        for (var i = 0; i < bit; i++)
        {
            byteArray[i] = 1;
        }
        return new SubnetMask(byteArray);
    }

    /// <summary>
    /// Calculate Subnetmask from IPAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <returns></returns>
    public static SubnetMask FromIPAddress(string ipAddress) => FromIPAddress(ipAddress.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from IPAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <returns></returns>
    public static SubnetMask FromIPAddress(ReadOnlySpan<char> ipAddress)
    {
        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        var loop = 1;
        foreach (var (split, endofLine) in ipAddress.SplitNoAlloc('.'))
        {
            var position = bitLength * loop - 1;
            var b = byte.Parse(split);
            var number = b;
            for (var i = bitLength - 1; i >= 0; i--)
            {
                byteArray[position] = Convert.ToByte(number & (2 - 1)); // n % m == n & (m - 1) 
                number = Convert.ToByte(number / 2);
                position--;
            }
            loop++;
        }
        return new SubnetMask(byteArray);
    }

    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="cidrAddress">CidrAddress. Format like 10.0.0.0/24</param>
    /// <returns></returns>
    public static (SubnetMask Address, SubnetMask Subnet) FromCidrAddress(string cidrAddress) => FromCidrAddress(cidrAddress.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="cidrAddress">CidrAddress. Format like 10.0.0.0/24</param>
    /// <returns></returns>
    public static (SubnetMask Address, SubnetMask Subnet) FromCidrAddress(ReadOnlySpan<char> cidrAddress)
    {
        var i = 0;
        Span<char> cidr = stackalloc char[15];
        Span<char> subnet = stackalloc char[2];
        foreach (var split in cidrAddress.SplitNoAlloc('/'))
        {
            if (i == 0)
            {
                split.Word.CopyTo(cidr);
                cidr = cidr.Slice(0, split.Word.Length);
            }
            else if (i == 1)
            {
                split.Word.CopyTo(subnet);
                subnet = subnet.Slice(0, split.Word.Length);
            }
            i++;
        }
        return FromCidrAddress(cidr, subnet);
    }

    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    public static (SubnetMask Address, SubnetMask Subnet) FromCidrAddress(string ipAddress, string subnetmask) => FromCidrAddress(ipAddress.AsSpan(), subnetmask.AsSpan());
    /// <summary>
    /// Calculate Subnetmask from CidrAddress
    /// </summary>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    public static (SubnetMask Address, SubnetMask Subnet) FromCidrAddress(ReadOnlySpan<char> ipAddress, ReadOnlySpan<char> subnetmask)
    {
        return (FromIPAddress(ipAddress), FromCidrNotion(byte.Parse(subnetmask)));
    }

    /// <summary>
    /// Calculate Networkmask.
    /// </summary>
    /// <example>
    /// Networkmask for 192.168.10.10/24 is 192.168.0.0
    /// </example>
    /// <param name="ipAddress">IPAddress. Format like 10.0.0.0</param>
    /// <param name="subnetmask">Subnetmask. Format like 24</param>
    /// <returns></returns>
    public static SubnetMask GetNetworkAddress(SubnetMask ipAddress, SubnetMask subnetmask)
    {
        Span<byte> networkmask = stackalloc byte[32];
        for (var i = 0; i < 32; i++)
        {
            networkmask[i] = (byte)(ipAddress.ByteArray[i] & subnetmask.ByteArray[i]);
        } 
        return new SubnetMask(networkmask);
    }

    /// <summary>
    /// Calculate Network Range for the NetworkAddress.
    /// </summary>
    /// <example>
    /// Networkmask for 192.168.10.10/24...
    /// BroadcastAddress is 192.168.10.255
    /// FirstAddress is 192.168.10.0
    /// EndAddress is 192.168.10.255
    /// </example>
    /// <param name="networkAddress">Network Address, Not IPAddress. format like 192.168.0.0</param>
    /// <param name="subnetmask">Subnetmask string. Format like 24</param>
    /// <returns></returns>
    public static (SubnetMask BroadcastAddress, SubnetMask FirstAddress, SubnetMask EndAddress) GetAddressRange(SubnetMask networkAddress, SubnetMask subnetmask)
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

        return (new SubnetMask(broadcastAddress), new SubnetMask(rangeFirstAddress), new SubnetMask(rangeLastAddress));
    }

    // 8
    public byte ToCidrNotion()
    {
        byte bit = 0;
        for (var i = 0; i < _byteArray.Length - 1; i++)
        {
            if (_byteArray[i] <= 0 || _byteArray[i] > 1) break;
            bit++;
        }
        return bit;
    }

    // 255.0.0.0
    public override string ToString()
    {
        // 00000000 00000000 00000000 00000000
        Span<byte> byteArray = stackalloc byte[bitLength * 4];
        var octet1 = CalculateOctet(_byteArray[..bitLength]);
        var octet2 = CalculateOctet(_byteArray[bitLength..(bitLength * 2)]);
        var octet3 = CalculateOctet(_byteArray[(bitLength * 2)..(bitLength * 3)]);
        var octet4 = CalculateOctet(_byteArray[(bitLength * 3)..(bitLength * 4)]);
        return $"{octet1}.{octet2}.{octet3}.{octet4}";
    }

    private byte CalculateOctet(ReadOnlySpan<byte> octet)
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
        return obj is SubnetMask mask && Equals(mask);
    }

    public bool Equals(SubnetMask other)
    {
        ReadOnlySpan<byte> l = ByteArray;
        ReadOnlySpan<byte> r = other.ByteArray;
        return l.SequenceEqual(r);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_byteArray);
    }

    public static bool operator ==(SubnetMask left, SubnetMask right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SubnetMask left, SubnetMask right)
    {
        return !(left == right);
    }
}
