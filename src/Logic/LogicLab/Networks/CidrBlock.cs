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
        var cidrTokens = cidrAddress.Split("/");
        if (cidrTokens.Length is not 2)
        {
            throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
        }
        var tokens = cidrTokens[0].Split(".");
        if (tokens.Length is not 4)
        {
            throw new FormatException($"{nameof(cidrAddress)} '{cidrAddress}' is incorrect format. Plase follow format 'xxx.xxx.xxx.xxx/xxx'.");
        }
        if (!byte.TryParse(tokens[0], out var cidr1))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr1)} '{cidr1}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(tokens[1], out var cidr2))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr2)} '{cidr2}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(tokens[2], out var cidr3))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr3)} '{cidr3}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(tokens[3], out var cidr4))
        {
            throw new ArgumentOutOfRangeException($"{nameof(cidr4)} '{cidr4}' is incorrect. Plase pass 0-255 value.");
        }
        if (!byte.TryParse(cidrTokens[1], out var subnet))
        {
            throw new ArgumentOutOfRangeException($"{nameof(subnet)} '{subnet}' is incorrect. Plase pass 0-32 value.");
        }

        ValidateSubnetValue(subnet);

        VpcCidr1 = cidr1;
        VpcCidr2 = cidr2;
        VpcCidr3 = cidr3;
        VpcCidr4 = cidr4;
        VpcCidrSubnet = subnet;
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
        if (subnet > 32) throw new ArgumentOutOfRangeException($"{nameof(subnet)} '{subnet}' is incorrect. Plase pass 0-32 value.");
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
