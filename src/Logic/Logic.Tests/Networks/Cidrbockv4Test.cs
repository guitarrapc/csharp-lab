using Logic.Core.Networks;

namespace Logic.Tests.Networks;

public class Cidrbockv4Test
{
    [Test]
    public async Task CtorStringTest()
    {
        var cidr = new CidrBlockv4("10.0.0.1/24");
        await Assert.That(cidr.VpcCidr1).IsEqualTo((byte)10);
        await Assert.That(cidr.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr4).IsEqualTo((byte)1);
        await Assert.That(cidr.VpcCidrSubnet).IsEqualTo((byte)24);

        var min = new CidrBlockv4("0.0.0.0/0");
        await Assert.That(min.VpcCidr1).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr4).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidrSubnet).IsEqualTo((byte)0);

        var max = new CidrBlockv4("255.255.255.255/32");
        await Assert.That(max.VpcCidr1).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr2).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr3).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr4).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidrSubnet).IsEqualTo((byte)32);
    }

    [Test]
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

    [Test]
    public async Task CtorBytesTest()
    {
        var cidr = new CidrBlockv4(10, 0, 0, 1, 24);
        await Assert.That(cidr.VpcCidr1).IsEqualTo((byte)10);
        await Assert.That(cidr.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr4).IsEqualTo((byte)1);
        await Assert.That(cidr.VpcCidrSubnet).IsEqualTo((byte)24);

        var min = new CidrBlockv4(0, 0, 0, 0, 0);
        await Assert.That(min.VpcCidr1).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr4).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidrSubnet).IsEqualTo((byte)0);

        var max = new CidrBlockv4(255, 255, 255, 255, 32);
        await Assert.That(max.VpcCidr1).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr2).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr3).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr4).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidrSubnet).IsEqualTo((byte)32);
    }

    [Test]
    public async Task CtorBytesThrowTest()
    {
        // byte protect value to 0-255
        Assert.Throws<ArgumentOutOfRangeException>(() => new CidrBlockv4(0, 0, 0, 0, 33)); // subnet over 32
    }


    [Test]
    public async Task TryParseStringTest()
    {
        var result = CidrBlockv4.TryParse("10.0.0.1/24", out var cidr);
        await Assert.That(result).IsTrue();
        await Assert.That(cidr.VpcCidr1).IsEqualTo((byte)10);
        await Assert.That(cidr.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr4).IsEqualTo((byte)1);
        await Assert.That(cidr.VpcCidrSubnet).IsEqualTo((byte)24);

        var result2 = CidrBlockv4.TryParse("0.0.0.0/0", out var min);
        await Assert.That(result2).IsTrue();
        await Assert.That(min.VpcCidr1).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr4).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidrSubnet).IsEqualTo((byte)0);

        var result3 = CidrBlockv4.TryParse("255.255.255.255/32", out var max);
        await Assert.That(result3).IsTrue();
        await Assert.That(max.VpcCidr1).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr2).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr3).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr4).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidrSubnet).IsEqualTo((byte)32);

        await Assert.That(CidrBlockv4.TryParse("0.0.0.0/-1", out _)).IsFalse(); // subnet negative
        await Assert.That(CidrBlockv4.TryParse("0.0.0.0/33", out _)).IsFalse(); // subnet over 32
        await Assert.That(CidrBlockv4.TryParse("255.255.255.255/33", out _)).IsFalse(); // subnet over 32
        await Assert.That(CidrBlockv4.TryParse("256.255.255.255/32", out _)).IsFalse(); // octed over 255
        await Assert.That(CidrBlockv4.TryParse("255.256.255.255/32", out _)).IsFalse(); // octed over 255
        await Assert.That(CidrBlockv4.TryParse("255.255.256.255/32", out _)).IsFalse(); // octed over 255
        await Assert.That(CidrBlockv4.TryParse("255.255.255.256/32", out _)).IsFalse(); // octed over 255

        await Assert.That(CidrBlockv4.TryParse("10.0.0.1", out _)).IsFalse(); // missing subnet
        await Assert.That(CidrBlockv4.TryParse("10.0.01/32", out _)).IsFalse(); // octed failure
        await Assert.That(CidrBlockv4.TryParse("10.001/32", out _)).IsFalse(); // octed failure
        await Assert.That(CidrBlockv4.TryParse("10001/32", out _)).IsFalse(); // octed failure

    }

    [Test]
    public async Task TryParseBytesTest()
    {
        var result = CidrBlockv4.TryParse(10, 0, 0, 1, 24, out var cidr);
        await Assert.That(result).IsTrue();
        await Assert.That(cidr.VpcCidr1).IsEqualTo((byte)10);
        await Assert.That(cidr.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(cidr.VpcCidr4).IsEqualTo((byte)1);
        await Assert.That(cidr.VpcCidrSubnet).IsEqualTo((byte)24);

        var result2 = CidrBlockv4.TryParse(0, 0, 0, 0, 0, out var min);
        await Assert.That(result2).IsTrue();
        await Assert.That(min.VpcCidr1).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr2).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr3).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidr4).IsEqualTo((byte)0);
        await Assert.That(min.VpcCidrSubnet).IsEqualTo((byte)0);

        var result3 = CidrBlockv4.TryParse(255, 255, 255, 255, 32, out var max);
        await Assert.That(result3).IsTrue();
        await Assert.That(max.VpcCidr1).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr2).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr3).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidr4).IsEqualTo((byte)255);
        await Assert.That(max.VpcCidrSubnet).IsEqualTo((byte)32);

        await Assert.That(CidrBlockv4.TryParse(0, 0, 0, 0, 33, out _)).IsFalse(); // subnet over 32
    }
}
