namespace LogicLab.Networks;

public readonly struct CidrBlock : IEquatable<CidrBlock>
{
    public readonly byte VpcCidr1;
    public readonly byte VpcCidr2;
    public readonly byte VpcCidr3;
    public readonly byte VpcCidr4;
    public readonly byte VpcCidrSubnet;

    public CidrBlock(string cidrAddress)
    {
        // cidrAddress.Split("/");
        var i = 0;
        Span<char> address = stackalloc char[15];
        Span<char> subnetmask = stackalloc char[2];
        foreach (var cidrToken in cidrAddress.SplitNoAlloc('/'))
        {
            switch (i)
            {
                case 0:
                    cidrToken.Word.CopyTo(address);
                    address = address.Slice(0, cidrToken.Word.Length);
                    break;
                case 1:
                    cidrToken.Word.CopyTo(subnetmask);
                    subnetmask = subnetmask.Slice(0, cidrToken.Word.Length);
                    break;
                default:
                    throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
            }
            i++;
        }
        if (i != 2)
        {
            throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
        }

        // cidrTokens[0].Split(".");
        var j = 0;
        Span<char> oct1 = stackalloc char[3];
        Span<char> oct2 = stackalloc char[3];
        Span<char> oct3 = stackalloc char[3];
        Span<char> oct4 = stackalloc char[3];
        foreach (var token in address.SplitNoAlloc('.'))
        {
            if (token.Word.Length > 3)
            {
                throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
            }
            switch (j)
            {
                case 0:
                    token.Word.CopyTo(oct1);
                    oct1 = oct1.Slice(0, token.Word.Length);
                    break;
                case 1:
                    token.Word.CopyTo(oct2);
                    oct2 = oct2.Slice(0, token.Word.Length);
                    break;
                case 2:
                    token.Word.CopyTo(oct3);
                    oct3 = oct3.Slice(0, token.Word.Length);
                    break;
                case 3:
                    token.Word.CopyTo(oct4);
                    oct4 = oct4.Slice(0, token.Word.Length);
                    break;
                default:
                    throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
            }
            j++;
        }
        if (j != 4)
        {
            throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
        }

        if (!byte.TryParse(oct1, out var cidr1))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr1)} '{cidr1}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(oct2, out var cidr2))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr2)} '{cidr2}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(oct3, out var cidr3))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr3)} '{cidr3}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(oct4, out var cidr4))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr4)} '{cidr4}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(subnetmask, out var subnet))
        {
            throw new ArgumentOutOfRangeException($"{nameof(subnet)} '{subnet}' is incorrect. Plase pass 0-32 value.");
        }

        ValidateSubnetValue(subnet);
        (VpcCidr1, VpcCidr2, VpcCidr3, VpcCidr4, VpcCidrSubnet) = (cidr1, cidr2, cidr3, cidr4, subnet);
    }

    public CidrBlock(byte cidr1, byte cidr2, byte cidr3, byte cidr4, byte subnet)
    {
        ValidateSubnetValue(subnet);
        (VpcCidr1, VpcCidr2, VpcCidr3, VpcCidr4, VpcCidrSubnet) = (cidr1, cidr2, cidr3, cidr4, subnet);
    }

    /// <summary>
    /// Validate subnet is valid value. Byte protect value from 0-255, so we just need subnet value check.
    /// </summary>
    /// <param name="subnet"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static void ValidateSubnetValue(byte subnet)
    {
        if (subnet > 32)
        {
            throw new ArgumentOutOfRangeException($"{nameof(subnet)} '{subnet}' is incorrect. Plase pass 0-32 value.");
        }
    }

    /// <summary>
    /// Add CidrBlock and create new CidrBlock
    /// </summary>
    /// <param name="cidrBlock"></param>
    /// <returns></returns>
    public CidrBlock AddCidr(CidrBlock cidrBlock)
        => new CidrBlock(
            (byte)(VpcCidr1 + cidrBlock.VpcCidr1),
            (byte)(VpcCidr2 + cidrBlock.VpcCidr2),
            (byte)(VpcCidr3 + cidrBlock.VpcCidr3),
            (byte)(VpcCidr4 + cidrBlock.VpcCidr4),
            (byte)(VpcCidrSubnet + cidrBlock.VpcCidrSubnet));

    public bool Equals(CidrBlock other)
    {
        return other is CidrBlock block && Equals(block);
    }

    public override bool Equals(object? obj)
    {
        return obj is CidrBlock block &&
               VpcCidr1 == block.VpcCidr1 &&
               VpcCidr2 == block.VpcCidr2 &&
               VpcCidr3 == block.VpcCidr3 &&
               VpcCidr4 == block.VpcCidr4 &&
               VpcCidrSubnet == block.VpcCidrSubnet;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(VpcCidr1, VpcCidr2, VpcCidr3, VpcCidr4, VpcCidrSubnet);
    }

    public override string ToString()
    {
        return $"{VpcCidr1}.{VpcCidr2}.{VpcCidr3}.{VpcCidr4}/{VpcCidrSubnet}";
    }

    public static bool TryParse(string cidrAddress, out CidrBlock cidrBlock)
    {
        cidrBlock = default;
        try
        {
            cidrBlock = new CidrBlock(cidrAddress);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool TryParse(byte cidr1, byte cidr2, byte cidr3, byte cidr4, byte subnet, out CidrBlock cidrBlock)
    {
        cidrBlock = default;

        if (subnet > 32)
        {
            return false;
        }

        try
        {
            cidrBlock = new CidrBlock(cidr1, cidr2, cidr3, cidr4, subnet);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool operator ==(CidrBlock left, CidrBlock right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(CidrBlock left, CidrBlock right)
    {
        return !(left == right);
    }
}
