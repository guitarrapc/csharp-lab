using Logic.Networks;
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
        actual.ByteArray.SequenceEqual(expected).Should().BeTrue();

        // 00000000 00000000 00000000 00000000
        var min = SubnetMaskv4.FromPrefix(0);
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        min.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111
        var max = SubnetMaskv4.FromPrefix(32);
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        max.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
    }

    [Fact]
    public void FromCidrTest()
    {
        // 00001010 00000000 00000000 00000000 / 00011000
        var actual = SubnetMaskv4.FromCidr("10.0.0.0/24");
        var expectedAddress = SubnetExtensions.CidrToBiteArray("10.0.0.0");
        var expectedSubnet = SubnetExtensions.CidrToBiteArray("255.255.255.0");
        actual.Address.ByteArray.SequenceEqual(expectedAddress).Should().BeTrue();
        actual.Subnet.ByteArray.SequenceEqual(expectedSubnet).Should().BeTrue();

        // 00000000 00000000 00000000 00000000 / 00000000
        var min = SubnetMaskv4.FromCidr("0.0.0.0/0");
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        var expectedSubnetMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        min.Address.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();
        min.Subnet.ByteArray.SequenceEqual(expectedSubnetMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111 / 11111111
        var max = SubnetMaskv4.FromCidr("255.255.255.255/32");
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        var expectedSubnetMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        max.Address.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
        max.Subnet.ByteArray.SequenceEqual(expectedSubnetMax).Should().BeTrue();

        // 00001010 00000000 00000000 00000000 / 00011000
        var actual2 = SubnetMaskv4.FromCidr("10.0.0.0", "24");
        var expectedAddress2 = SubnetExtensions.CidrToBiteArray("10.0.0.0");
        var expectedSubnet2 = SubnetExtensions.CidrToBiteArray("255.255.255.0");
        actual2.Address.ByteArray.SequenceEqual(expectedAddress2).Should().BeTrue();
        actual2.Subnet.ByteArray.SequenceEqual(expectedSubnet2).Should().BeTrue();

        // 00000000 00000000 00000000 00000000 / 00000000
        var min2 = SubnetMaskv4.FromCidr("0.0.0.0", "0");
        var expectedMin2 = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        var expectedSubnetMin2 = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        min2.Address.ByteArray.SequenceEqual(expectedMin2).Should().BeTrue();
        min2.Subnet.ByteArray.SequenceEqual(expectedSubnetMin2).Should().BeTrue();

        // 11111111 11111111 11111111 11111111 / 11111111
        var max2 = SubnetMaskv4.FromCidr("255.255.255.255", "32");
        var expectedMax2 = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        var expectedSubnetMax2 = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        max2.Address.ByteArray.SequenceEqual(expectedMax2).Should().BeTrue();
        max2.Subnet.ByteArray.SequenceEqual(expectedSubnetMax2).Should().BeTrue();
    }

    [Fact]
    public void FromIPAddressTest()
    {
        // 00001010 00000000 00000000 00000000
        var expected = SubnetExtensions.CidrToBiteArray("10.0.0.0");
        var actual = SubnetMaskv4.FromIPAddress("10.0.0.0");
        var actual2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("10.0.0.0"));
        actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        actual2.ByteArray.SequenceEqual(expected).Should().BeTrue();

        // 00000000 00000000 00000000 00000000
        var expectedMin = SubnetExtensions.CidrToBiteArray("0.0.0.0");
        var actualMin = SubnetMaskv4.FromIPAddress("0.0.0.0");
        var actualMin2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("0.0.0.0"));
        actualMin.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();
        actualMin2.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111
        var expectedMax = SubnetExtensions.CidrToBiteArray("255.255.255.255");
        var actualMax = SubnetMaskv4.FromIPAddress("255.255.255.255");
        var actualMax2 = SubnetMaskv4.FromIPAddress(IPAddress.Parse("255.255.255.255"));
        actualMax.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
        actualMax2.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
    }

    [Fact]
    public void GetNetworkAddressTest()
    {
        {
            // 32
            var cidr = SubnetMaskv4.FromCidr("192.168.150.121/32");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.150.121");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // 110 - .111
            var cidr = SubnetMaskv4.FromCidr("192.168.140.111/31");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.140.110");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // .88 - .91
            var cidr = SubnetMaskv4.FromCidr("192.168.130.90/30");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.130.88");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // .96 - .103
            var cidr = SubnetMaskv4.FromCidr("192.168.100.101/29");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.100.96");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .192 - .207
            var cidr = SubnetMaskv4.FromCidr("192.168.120.200/28");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.120.192");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .32 - .63
            var cidr = SubnetMaskv4.FromCidr("192.168.90.50/27");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.90.32");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .63
            var cidr = SubnetMaskv4.FromCidr("192.168.80.30/26");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.80.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .127
            var cidr = SubnetMaskv4.FromCidr("192.168.70.30/25");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.70.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .255
            var cidr = SubnetMaskv4.FromCidr("192.168.60.30/24");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.60.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .50.0 - .51.255
            var cidr = SubnetMaskv4.FromCidr("192.168.50.30/23");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("192.168.50.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .16.0.0 - .16.255.255
            var cidr = SubnetMaskv4.FromCidr("172.16.40.30/16");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("172.16.0.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // 10.0.0.0 - 10.255.255.255
            var cidr = SubnetMaskv4.FromCidr("10.1.100.30/8");
            var actual = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = SubnetExtensions.CidrToBiteArray("10.0.0.0");
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
    }

    [Fact]
    public void GetAddressRangeTest()
    {
        {
            // .121
            var cidr = SubnetMaskv4.FromCidr("192.168.150.121", "32");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.150.121");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.150.121");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.150.121");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // 110 - .111
            var cidr = SubnetMaskv4.FromCidr("192.168.140.111", "31");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.140.111");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.140.110");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.140.111");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .88 - .91
            var cidr = SubnetMaskv4.FromCidr("192.168.130.90", "30");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.130.91");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.130.88");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.130.91");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .96 - .103
            var cidr = SubnetMaskv4.FromCidr("192.168.100.101", "29");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.100.103");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.100.96");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.100.103");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .192 - .207
            var cidr = SubnetMaskv4.FromCidr("192.168.120.200", "28");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.120.207");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.120.192");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.120.207");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .32 - .63
            var cidr = SubnetMaskv4.FromCidr("192.168.90.50", "27");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.90.63");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.90.32");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.90.63");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .63
            var cidr = SubnetMaskv4.FromCidr("192.168.80.30", "26");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.80.63");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.80.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.80.63");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .127
            var cidr = SubnetMaskv4.FromCidr("192.168.70.30", "25");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.70.127");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.70.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.70.127");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .255
            var cidr = SubnetMaskv4.FromCidr("192.168.60.1", "24");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.60.255");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.60.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.60.255");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .50.0 - .51.255
            var cidr = SubnetMaskv4.FromCidr("192.168.50.30", "23");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("192.168.51.255");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("192.168.50.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("192.168.51.255");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .16.0.0 - .16.255.255
            var cidr = SubnetMaskv4.FromCidr("172.16.40.30", "16");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("172.16.255.255");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("172.16.0.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("172.16.255.255");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // 10.0.0.0 - 10.255.255.255
            var cidr = SubnetMaskv4.FromCidr("10.1.100.30", "8");
            var networkAddress = SubnetMaskv4.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMaskv4.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = SubnetExtensions.CidrToBiteArray("10.255.255.255");
            var expectedFirst = SubnetExtensions.CidrToBiteArray("10.0.0.0");
            var expectedEnd = SubnetExtensions.CidrToBiteArray("10.255.255.255");
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }
    }

    [Fact]
    public void EqualsTest()
    {
        var a = SubnetMaskv4.FromCidr("192.168.10.10/24");
        var b = SubnetMaskv4.FromCidr("192.168.10.10/24");
        var c = SubnetMaskv4.FromCidr("192.168.10.10/25");
        a.Equals(b).Should().BeTrue();
        a.Equals(c).Should().BeFalse();
        (a == b).Should().BeTrue();
        (a == c).Should().BeFalse();

        var d = SubnetMaskv4.FromCidr("10.0.0.1/16");
        var e = SubnetMaskv4.FromCidr("10.0.0.1/16");
        var f = SubnetMaskv4.FromCidr("10.1.0.2/16");
        d.Equals(e).Should().BeTrue();
        d.Equals(f).Should().BeFalse();
        (d == e).Should().BeTrue();
        (d == f).Should().BeFalse();
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
