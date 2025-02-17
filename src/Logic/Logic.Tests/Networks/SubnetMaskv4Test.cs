using Logic.Core.Networks;
using System.Net;

namespace Logic.Tests.Networks;

public class SubnetMaskv4Test
{
    [Fact]
    public void FromPrefixTest()
    {
        // 11111111 11111111 11111111 00000000
        var actual = SubnetMaskv4.FromPrefix(24);
        var expected = SubnetExtensions.CidrToBiteArray("255.255.255.0");
        Assert.True(actual.ByteArray.SequenceEqual(expected));

        // 00000000 00000000 00000000 00000000
        var min = SubnetMaskv4.FromPrefix(0);
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        Assert.True(min.ByteArray.SequenceEqual(expectedMin));

        // 11111111 11111111 11111111 11111111
        var max = SubnetMaskv4.FromPrefix(32);
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        Assert.True(max.ByteArray.SequenceEqual(expectedMax));
    }

    [Fact]
    public void FromCidrTest()
    {
        // 00001010 00000000 00000000 00000000 / 00011000
        var actual = SubnetMaskv4.FromCidr("10.0.0.0/24");
        var expectedAddress = SubnetExtensions.CidrToBiteArray("10.0.0.0");
        var expectedSubnet = SubnetExtensions.CidrToBiteArray("255.255.255.0");
        Assert.True(actual.Address.ByteArray.SequenceEqual(expectedAddress));
        Assert.True(actual.Subnet.ByteArray.SequenceEqual(expectedSubnet));

        // 00000000 00000000 00000000 00000000 / 00000000
        var min = SubnetMaskv4.FromCidr("0.0.0.0/0");
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        var expectedSubnetMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        Assert.True(min.Address.ByteArray.SequenceEqual(expectedMin));
        Assert.True(min.Subnet.ByteArray.SequenceEqual(expectedSubnetMin));

        // 11111111 11111111 11111111 11111111 / 11111111
        var max = SubnetMaskv4.FromCidr("255.255.255.255/32");
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        var expectedSubnetMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        Assert.True(max.Address.ByteArray.SequenceEqual(expectedMax));
        Assert.True(max.Subnet.ByteArray.SequenceEqual(expectedSubnetMax));
    }

    [Fact]
    public void FromIPAddressTest()
    {
        // 00001010 00000000 00000000 00000000
        var expected = SubnetExtensions.CidrToBiteArray("10.0.0.0");
        var actual = SubnetMaskv4.FromIPAddress("10.0.0.0");
        var actual2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("10.0.0.0"));
        Assert.True(actual.ByteArray.SequenceEqual(expected));
        Assert.True(actual2.ByteArray.SequenceEqual(expected));

        // 00000000 00000000 00000000 00000000
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        var actualMin = SubnetMaskv4.FromIPAddress("0.0.0.0");
        var actualMin2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("0.0.0.0"));
        Assert.True(actualMin.ByteArray.SequenceEqual(expectedMin));
        Assert.True(actualMin2.ByteArray.SequenceEqual(expectedMin));

        // 11111111 11111111 11111111 11111111
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        var actualMax = SubnetMaskv4.FromIPAddress("255.255.255.255");
        var actualMax2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("255.255.255.255"));
        Assert.True(actualMax.ByteArray.SequenceEqual(expectedMax));
        Assert.True(actualMax2.ByteArray.SequenceEqual(expectedMax));
    }

    [Theory]
    [InlineData("192.168.150.121/32", "192.168.150.121")]
    [InlineData("192.168.140.111/31", "192.168.140.110")]
    [InlineData("192.168.130.90/30", "192.168.130.88")]
    [InlineData("192.168.100.101/29", "192.168.100.96")]
    [InlineData("192.168.120.200/28", "192.168.120.192")]
    [InlineData("192.168.90.50/27", "192.168.90.32")]
    [InlineData("192.168.80.30/26", "192.168.80.0")]
    [InlineData("192.168.70.30/25", "192.168.70.0")]
    [InlineData("192.168.60.30/24", "192.168.60.0")]
    [InlineData("192.168.50.30/23", "192.168.50.0")]
    [InlineData("172.16.40.30/16", "172.16.0.0")]
    [InlineData("10.1.100.30/8", "10.0.0.0")]
    public void GetNetworkAddressTest(string cidrAddress, string expectedAddress)
    {
        var (Address, Subnet) = SubnetMaskv4.FromCidr(cidrAddress);
        var actual = SubnetMaskv4.GetNetworkAddress(Address, Subnet);
        var expected = SubnetExtensions.CidrToBiteArray(expectedAddress);
        Assert.True(actual.ByteArray.SequenceEqual(expected));
    }

    [Theory]
    [InlineData("192.168.150.121/32", "192.168.150.121", "192.168.150.121", "192.168.150.121")]
    [InlineData("192.168.140.111/31", "192.168.140.111", "192.168.140.110", "192.168.140.111")]
    [InlineData("192.168.130.90/30", "192.168.130.91", "192.168.130.88", "192.168.130.91")]
    [InlineData("192.168.100.101/29", "192.168.100.103", "192.168.100.96", "192.168.100.103")]
    [InlineData("192.168.120.200/28", "192.168.120.207", "192.168.120.192", "192.168.120.207")]
    [InlineData("192.168.90.50/27", "192.168.90.63", "192.168.90.32", "192.168.90.63")]
    [InlineData("192.168.80.30/26", "192.168.80.63", "192.168.80.0", "192.168.80.63")]
    [InlineData("192.168.70.30/25", "192.168.70.127", "192.168.70.0", "192.168.70.127")]
    [InlineData("192.168.60.1/24", "192.168.60.255", "192.168.60.0", "192.168.60.255")]
    [InlineData("192.168.50.30/23", "192.168.51.255", "192.168.50.0", "192.168.51.255")]
    [InlineData("172.16.40.30/16", "172.16.255.255", "172.16.0.0", "172.16.255.255")]
    [InlineData("10.1.100.30/8", "10.255.255.255", "10.0.0.0", "10.255.255.255")]
    public void GetAddressRangeTest(string cidraddress, string expectedBroadcastAddress, string expectedFirstAddress, string expectedEndAddress)
    {
        var expectedBroadcast = SubnetExtensions.CidrToBiteArray(expectedBroadcastAddress);
        var expectedFirst = SubnetExtensions.CidrToBiteArray(expectedFirstAddress);
        var expectedEnd = SubnetExtensions.CidrToBiteArray(expectedEndAddress);

        var cidr = SubnetMaskv4.FromCidr(cidraddress);
        var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
        var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);

        Assert.True(addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast));
        Assert.True(addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst));
        Assert.True(addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd));
    }

    [Fact]
    public void EqualsTest()
    {
        var a = SubnetMaskv4.FromCidr("192.168.10.10/24");
        var b = SubnetMaskv4.FromCidr("192.168.10.10/24");
        var c = SubnetMaskv4.FromCidr("192.168.10.10/25");
        Assert.Equal(b, a);
        Assert.NotEqual(c, a);
        Assert.True(a == b);
        Assert.False(a == c);

        var d = SubnetMaskv4.FromCidr("10.0.0.1/16");
        var e = SubnetMaskv4.FromCidr("10.0.0.1/16");
        var f = SubnetMaskv4.FromCidr("10.1.0.2/16");
        Assert.Equal(e, d);
        Assert.NotEqual(f, d);
        Assert.True(d == e);
        Assert.False(d == f);
    }
}

public static class SubnetExtensions
{
    /// <summary>
    /// Convert decimal int to binary array.
    /// 255.255.255.255 -> {
    ///     1, 1, 1, 1, 1, 1, 1, 1,
    ///     1, 1, 1, 1, 1, 1, 1, 1,
    ///     1, 1, 1, 1, 1, 1, 1, 1,
    ///     1, 1, 1, 1, 1, 1, 1, 1
    /// }
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static byte[] CidrToBiteArray(string cidr)
    {
        var array = cidr.Split(".");
        return array
            .Select(x => int.Parse(x))
            .SelectMany(x => ToBinaryArray(x))
            .ToArray();
    }

    /// <summary>
    /// Convert decimal int to binary array.
    /// 10 -> { 0, 0, 0, 0, 1, 0, 1, 0 }
    /// 255 -> { 1, 1, 1, 1, 1, 1, 1, 1 }
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static byte[] ToBinaryArray(int num)
    {
        return Enumerable
            .Range(0, 8)
            .Select(i => (num >> (7 - i)) & 1)
            .Select(x => Convert.ToByte(x))
            .ToArray();
    }
}
