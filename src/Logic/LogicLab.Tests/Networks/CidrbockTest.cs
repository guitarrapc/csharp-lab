using LogicLab.Networks;

namespace LogicLab.Tests.Networks;

public class CidrbockTest
{
    [Fact]
    public async Task CtorStringTest()
    {
        var cidr = new CidrBlock("10.0.0.1/24");
        cidr.VpcCidr1.Should().Be(10);
        cidr.VpcCidr2.Should().Be(0);
        cidr.VpcCidr3.Should().Be(0);
        cidr.VpcCidr4.Should().Be(1);
        cidr.VpcCidrSubnet.Should().Be(24);

        var min = new CidrBlock("0.0.0.0/0");
        min.VpcCidr1.Should().Be(0);
        min.VpcCidr2.Should().Be(0);
        min.VpcCidr3.Should().Be(0);
        min.VpcCidr4.Should().Be(0);
        min.VpcCidrSubnet.Should().Be(0);

        var max = new CidrBlock("255.255.255.255/32");
        max.VpcCidr1.Should().Be(255);
        max.VpcCidr2.Should().Be(255);
        max.VpcCidr3.Should().Be(255);
        max.VpcCidr4.Should().Be(255);
        max.VpcCidrSubnet.Should().Be(32);
    }

    [Fact]
    public async Task CtorStringThrowTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("0.0.0.0/-1")); // subnet negative
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("0.0.0.0/33")); // subnet over 32
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("255.255.255.255/33")); // subnet over 32
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("256.255.255.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("255.256.255.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("255.255.256.255/32")); // octed over 255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock("255.255.255.256/32")); // octed over 255

        Assert.Throws<FormatException>(() => new CidrBlock("10.0.0.1")); // missing subnet
        Assert.Throws<FormatException>(() => new CidrBlock("10.0.01/32")); // octed failure
        Assert.Throws<FormatException>(() => new CidrBlock("10.001/32")); // octed failure
        Assert.Throws<FormatException>(() => new CidrBlock("10001/32")); // octed failure
    }

    [Fact]
    public async Task CtorBytesTest()
    {
        var cidr = new CidrBlock(10, 0, 0, 1, 24);
        cidr.VpcCidr1.Should().Be(10);
        cidr.VpcCidr2.Should().Be(0);
        cidr.VpcCidr3.Should().Be(0);
        cidr.VpcCidr4.Should().Be(1);
        cidr.VpcCidrSubnet.Should().Be(24);

        var min = new CidrBlock(0, 0, 0, 0, 0);
        min.VpcCidr1.Should().Be(0);
        min.VpcCidr2.Should().Be(0);
        min.VpcCidr3.Should().Be(0);
        min.VpcCidr4.Should().Be(0);
        min.VpcCidrSubnet.Should().Be(0);

        var max = new CidrBlock(255, 255, 255, 255,32);
        max.VpcCidr1.Should().Be(255);
        max.VpcCidr2.Should().Be(255);
        max.VpcCidr3.Should().Be(255);
        max.VpcCidr4.Should().Be(255);
        max.VpcCidrSubnet.Should().Be(32);
    }

    [Fact]
    public async Task CtorBytesThrowTest()
    {
        // byte protect value to 0-255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlock(0, 0, 0, 0, 33)); // subnet over 32
    }


    [Fact]
    public async Task TryParseStringTest()
    {
        var result = CidrBlock.TryParse("10.0.0.1/24", out var cidr);
        result.Should().BeTrue();
        cidr.VpcCidr1.Should().Be(10);
        cidr.VpcCidr2.Should().Be(0);
        cidr.VpcCidr3.Should().Be(0);
        cidr.VpcCidr4.Should().Be(1);
        cidr.VpcCidrSubnet.Should().Be(24);

        var result2 = CidrBlock.TryParse("0.0.0.0/0", out var min);
        result2.Should().BeTrue();
        min.VpcCidr1.Should().Be(0);
        min.VpcCidr2.Should().Be(0);
        min.VpcCidr3.Should().Be(0);
        min.VpcCidr4.Should().Be(0);
        min.VpcCidrSubnet.Should().Be(0);

        var result3 = CidrBlock.TryParse("255.255.255.255/32", out var max);
        result3.Should().BeTrue();
        max.VpcCidr1.Should().Be(255);
        max.VpcCidr2.Should().Be(255);
        max.VpcCidr3.Should().Be(255);
        max.VpcCidr4.Should().Be(255);
        max.VpcCidrSubnet.Should().Be(32);

        CidrBlock.TryParse("0.0.0.0/-1", out _).Should().BeFalse(); // subnet negative
        CidrBlock.TryParse("0.0.0.0/33", out _).Should().BeFalse(); // subnet over 32
        CidrBlock.TryParse("255.255.255.255/33", out _).Should().BeFalse(); // subnet over 32
        CidrBlock.TryParse("256.255.255.255/32", out _).Should().BeFalse(); // octed over 255
        CidrBlock.TryParse("255.256.255.255/32", out _).Should().BeFalse(); // octed over 255
        CidrBlock.TryParse("255.255.256.255/32", out _).Should().BeFalse(); // octed over 255
        CidrBlock.TryParse("255.255.255.256/32", out _).Should().BeFalse(); // octed over 255

        CidrBlock.TryParse("10.0.0.1", out _).Should().BeFalse(); // missing subnet
        CidrBlock.TryParse("10.0.01/32", out _).Should().BeFalse(); // octed failure
        CidrBlock.TryParse("10.001/32", out _).Should().BeFalse(); // octed failure
        CidrBlock.TryParse("10001/32", out _).Should().BeFalse(); // octed failure

    }

    [Fact]
    public async Task TryParseBytesTest()
    {
        var result = CidrBlock.TryParse(10, 0, 0, 1, 24, out var cidr);
        result.Should().BeTrue();
        cidr.VpcCidr1.Should().Be(10);
        cidr.VpcCidr2.Should().Be(0);
        cidr.VpcCidr3.Should().Be(0);
        cidr.VpcCidr4.Should().Be(1);
        cidr.VpcCidrSubnet.Should().Be(24);

        var result2 = CidrBlock.TryParse(0,0,0,0,0, out var min);
        result2.Should().BeTrue();
        min.VpcCidr1.Should().Be(0);
        min.VpcCidr2.Should().Be(0);
        min.VpcCidr3.Should().Be(0);
        min.VpcCidr4.Should().Be(0);
        min.VpcCidrSubnet.Should().Be(0);

        var result3 = CidrBlock.TryParse(255,255,255,255,32, out var max);
        result3.Should().BeTrue();
        max.VpcCidr1.Should().Be(255);
        max.VpcCidr2.Should().Be(255);
        max.VpcCidr3.Should().Be(255);
        max.VpcCidr4.Should().Be(255);
        max.VpcCidrSubnet.Should().Be(32);

        CidrBlock.TryParse(0, 0, 0, 0, 33, out _).Should().BeFalse(); // subnet over 32
    }
}
