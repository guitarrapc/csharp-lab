using Logic.Core.Networks;

namespace Logic.Tests.Networks;

public class Cidrbockv4Test
{
    [Fact]
    public async Task CtorStringTest()
    {
        var cidr = new CidrBlockv4("10.0.0.1/24");
        Assert.Equal(10, cidr.VpcCidr1);
        Assert.Equal(0, cidr.VpcCidr2);
        Assert.Equal(0, cidr.VpcCidr3);
        Assert.Equal(1, cidr.VpcCidr4);
        Assert.Equal(24, cidr.VpcCidrSubnet);

        var min = new CidrBlockv4("0.0.0.0/0");
        Assert.Equal(0, min.VpcCidr1);
        Assert.Equal(0, min.VpcCidr2);
        Assert.Equal(0, min.VpcCidr3);
        Assert.Equal(0, min.VpcCidr4);
        Assert.Equal(0, min.VpcCidrSubnet);

        var max = new CidrBlockv4("255.255.255.255/32");
        Assert.Equal(255, max.VpcCidr1);
        Assert.Equal(255, max.VpcCidr2);
        Assert.Equal(255, max.VpcCidr3);
        Assert.Equal(255, max.VpcCidr4);
        Assert.Equal(32, max.VpcCidrSubnet);
    }

    [Fact]
    public async Task CtorStringThrowTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("0.0.0.0/-1")); // subnet negative
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("0.0.0.0/33")); // subnet over 32
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("255.255.255.255/33")); // subnet over 32
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("256.255.255.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("255.256.255.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("255.255.256.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4("255.255.255.256/32")); // octed over 255

        Assert.Throws<FormatException>(() => new CidrBlockv4("10.0.0.1")); // missing subnet
        Assert.Throws<FormatException>(() => new CidrBlockv4("10.0.01/32")); // octed failure
        Assert.Throws<FormatException>(() => new CidrBlockv4("10.001/32")); // octed failure
        Assert.Throws<FormatException>(() => new CidrBlockv4("10001/32")); // octed failure
    }

    [Fact]
    public async Task CtorBytesTest()
    {
        var cidr = new CidrBlockv4(10, 0, 0, 1, 24);
        Assert.Equal(10, cidr.VpcCidr1);
        Assert.Equal(0, cidr.VpcCidr2);
        Assert.Equal(0, cidr.VpcCidr3);
        Assert.Equal(1, cidr.VpcCidr4);
        Assert.Equal(24, cidr.VpcCidrSubnet);

        var min = new CidrBlockv4(0, 0, 0, 0, 0);
        Assert.Equal(0, min.VpcCidr1);
        Assert.Equal(0, min.VpcCidr2);
        Assert.Equal(0, min.VpcCidr3);
        Assert.Equal(0, min.VpcCidr4);
        Assert.Equal(0, min.VpcCidrSubnet);

        var max = new CidrBlockv4(255, 255, 255, 255, 32);
        Assert.Equal(255, max.VpcCidr1);
        Assert.Equal(255, max.VpcCidr2);
        Assert.Equal(255, max.VpcCidr3);
        Assert.Equal(255, max.VpcCidr4);
        Assert.Equal(32, max.VpcCidrSubnet);
    }

    [Fact]
    public async Task CtorBytesThrowTest()
    {
        // byte protect value to 0-255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4(0, 0, 0, 0, 33)); // subnet over 32
    }


    [Fact]
    public async Task TryParseStringTest()
    {
        var result = CidrBlockv4.TryParse("10.0.0.1/24", out var cidr);
        Assert.True(result);
        Assert.Equal(10, cidr.VpcCidr1);
        Assert.Equal(0, cidr.VpcCidr2);
        Assert.Equal(0, cidr.VpcCidr3);
        Assert.Equal(1, cidr.VpcCidr4);
        Assert.Equal(24, cidr.VpcCidrSubnet);

        var result2 = CidrBlockv4.TryParse("0.0.0.0/0", out var min);
        Assert.True(result2);
        Assert.Equal(0, min.VpcCidr1);
        Assert.Equal(0, min.VpcCidr2);
        Assert.Equal(0, min.VpcCidr3);
        Assert.Equal(0, min.VpcCidr4);
        Assert.Equal(0, min.VpcCidrSubnet);

        var result3 = CidrBlockv4.TryParse("255.255.255.255/32", out var max);
        Assert.True(result3);
        Assert.Equal(255, max.VpcCidr1);
        Assert.Equal(255, max.VpcCidr2);
        Assert.Equal(255, max.VpcCidr3);
        Assert.Equal(255, max.VpcCidr4);
        Assert.Equal(32, max.VpcCidrSubnet);

        Assert.False(CidrBlockv4.TryParse("0.0.0.0/-1", out _)); // subnet negative
        Assert.False(CidrBlockv4.TryParse("0.0.0.0/33", out _)); // subnet over 32
        Assert.False(CidrBlockv4.TryParse("255.255.255.255/33", out _)); // subnet over 32
        Assert.False(CidrBlockv4.TryParse("256.255.255.255/32", out _)); // octed over 255
        Assert.False(CidrBlockv4.TryParse("255.256.255.255/32", out _)); // octed over 255
        Assert.False(CidrBlockv4.TryParse("255.255.256.255/32", out _)); // octed over 255
        Assert.False(CidrBlockv4.TryParse("255.255.255.256/32", out _)); // octed over 255

        Assert.False(CidrBlockv4.TryParse("10.0.0.1", out _)); // missing subnet
        Assert.False(CidrBlockv4.TryParse("10.0.01/32", out _)); // octed failure
        Assert.False(CidrBlockv4.TryParse("10.001/32", out _)); // octed failure
        Assert.False(CidrBlockv4.TryParse("10001/32", out _)); // octed failure

    }

    [Fact]
    public async Task TryParseBytesTest()
    {
        var result = CidrBlockv4.TryParse(10, 0, 0, 1, 24, out var cidr);
        Assert.True(result);
        Assert.Equal(10, cidr.VpcCidr1);
        Assert.Equal(0, cidr.VpcCidr2);
        Assert.Equal(0, cidr.VpcCidr3);
        Assert.Equal(1, cidr.VpcCidr4);
        Assert.Equal(24, cidr.VpcCidrSubnet);

        var result2 = CidrBlockv4.TryParse(0, 0, 0, 0, 0, out var min);
        Assert.True(result2);
        Assert.Equal(0, min.VpcCidr1);
        Assert.Equal(0, min.VpcCidr2);
        Assert.Equal(0, min.VpcCidr3);
        Assert.Equal(0, min.VpcCidr4);
        Assert.Equal(0, min.VpcCidrSubnet);

        var result3 = CidrBlockv4.TryParse(255, 255, 255, 255, 32, out var max);
        Assert.True(result3);
        Assert.Equal(255, max.VpcCidr1);
        Assert.Equal(255, max.VpcCidr2);
        Assert.Equal(255, max.VpcCidr3);
        Assert.Equal(255, max.VpcCidr4);
        Assert.Equal(32, max.VpcCidrSubnet);

        Assert.False(CidrBlockv4.TryParse(0, 0, 0, 0, 33, out _)); // subnet over 32
    }
}
