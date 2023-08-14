using LogicLab.Networks;

namespace LogicLab.Tests.Networks;

public class SubnetMaskTest
{
    [Fact]
    public void FromCidrNotionTest()
    {
        // 00011000
        var actual = SubnetMask.FromCidrNotion(24);
        var expected = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        actual.ByteArray.SequenceEqual(expected).Should().BeTrue();

        // 00000000
        var min = SubnetMask.FromCidrNotion(0);
        var expectedMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        min.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111 / 11111111
        var max = SubnetMask.FromCidrNotion(32);
        var expectedMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        max.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
    }

    [Fact]
    public void FromCidrAddressTest()
    {
        // 00001010 00000000 00000000 00000000 / 00011000
        var actual = SubnetMask.FromCidrAddress("10.0.0.0/24");
        var expectedAddress = new[] { 10.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnet = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        actual.Address.ByteArray.SequenceEqual(expectedAddress).Should().BeTrue();
        actual.Subnet.ByteArray.SequenceEqual(expectedSubnet).Should().BeTrue();

        // 00000000 00000000 00000000 00000000 / 00000000
        var min = SubnetMask.FromCidrAddress("0.0.0.0/0");
        var expectedMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnetMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        min.Address.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();
        min.Subnet.ByteArray.SequenceEqual(expectedSubnetMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111 / 11111111
        var max = SubnetMask.FromCidrAddress("255.255.255.255/32");
        var expectedMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnetMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        max.Address.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
        max.Subnet.ByteArray.SequenceEqual(expectedSubnetMax).Should().BeTrue();
    }

    [Fact]
    public void FromCidrAddressTest2()
    {
        // 00001010 00000000 00000000 00000000 / 00011000
        var actual = SubnetMask.FromCidrAddress("10.0.0.0", "24");
        var expectedAddress = new[] { 10.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnet = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        actual.Address.ByteArray.SequenceEqual(expectedAddress).Should().BeTrue();
        actual.Subnet.ByteArray.SequenceEqual(expectedSubnet).Should().BeTrue();

        // 00000000 00000000 00000000 00000000 / 00000000
        var min = SubnetMask.FromCidrAddress("0.0.0.0", "0");
        var expectedMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnetMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        min.Address.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();
        min.Subnet.ByteArray.SequenceEqual(expectedSubnetMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111 / 11111111
        var max = SubnetMask.FromCidrAddress("255.255.255.255", "32");
        var expectedMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        var expectedSubnetMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        max.Address.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
        max.Subnet.ByteArray.SequenceEqual(expectedSubnetMax).Should().BeTrue();
    }

    [Fact]
    public void FromIPAddressTest()
    {
        // 00001010 00000000 00000000 00000000
        var actual = SubnetMask.FromIPAddress("10.0.0.0");
        var expected = new[] { 10.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        actual.ByteArray.SequenceEqual(expected).Should().BeTrue();

        // 00000000 00000000 00000000 00000000
        var min = SubnetMask.FromIPAddress("0.0.0.0");
        var expectedMin = new[] { 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
        min.ByteArray.SequenceEqual(expectedMin).Should().BeTrue();

        // 11111111 11111111 11111111 11111111
        var max = SubnetMask.FromIPAddress("255.255.255.255");
        var expectedMax = new[] { 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
        max.ByteArray.SequenceEqual(expectedMax).Should().BeTrue();
    }

    [Fact]
    public void GetNetworkAddressTest()
    {
        {
            // .121
            var cidr = SubnetMask.FromCidrAddress("192.168.150.121", "32");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 150.ToBinaryArray(), 121.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // 110 - .111
            var cidr = SubnetMask.FromCidrAddress("192.168.140.111", "31");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 140.ToBinaryArray(), 110.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // .88 - .91
            var cidr = SubnetMask.FromCidrAddress("192.168.130.90", "30");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 130.ToBinaryArray(), 88.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
        {
            // .96 - .103
            var cidr = SubnetMask.FromCidrAddress("192.168.100.101", "29");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 100.ToBinaryArray(), 96.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .192 - .207
            var cidr = SubnetMask.FromCidrAddress("192.168.120.200", "28");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 120.ToBinaryArray(), 192.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .32 - .63
            var cidr = SubnetMask.FromCidrAddress("192.168.90.50", "27");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 90.ToBinaryArray(), 32.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .63
            var cidr = SubnetMask.FromCidrAddress("192.168.80.30", "26");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 80.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .127
            var cidr = SubnetMask.FromCidrAddress("192.168.70.30", "25");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 70.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .0 - .255
            var cidr = SubnetMask.FromCidrAddress("192.168.60.30", "24");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 60.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .50.0 - .51.255
            var cidr = SubnetMask.FromCidrAddress("192.168.50.30", "23");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 50.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // .16.0.0 - .16.255.255
            var cidr = SubnetMask.FromCidrAddress("172.16.40.30", "16");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 172.ToBinaryArray(), 16.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }

        {
            // 10.0.0.0 - 10.255.255.255
            var cidr = SubnetMask.FromCidrAddress("10.1.100.30", "8");
            var actual = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var expected = new[] { 10.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            actual.ByteArray.SequenceEqual(expected).Should().BeTrue();
        }
    }

    [Fact]
    public void GetAddressRangeTest()
    {
        {
            // .121
            var cidr = SubnetMask.FromCidrAddress("192.168.150.121", "32");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 150.ToBinaryArray(), 121.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 150.ToBinaryArray(), 121.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 150.ToBinaryArray(), 121.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // 110 - .111
            var cidr = SubnetMask.FromCidrAddress("192.168.140.111", "31");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 140.ToBinaryArray(), 111.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 140.ToBinaryArray(), 110.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 140.ToBinaryArray(), 111.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .88 - .91
            var cidr = SubnetMask.FromCidrAddress("192.168.130.90", "30");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 130.ToBinaryArray(), 91.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 130.ToBinaryArray(), 88.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 130.ToBinaryArray(), 91.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .96 - .103
            var cidr = SubnetMask.FromCidrAddress("192.168.100.101", "29");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 100.ToBinaryArray(), 103.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 100.ToBinaryArray(), 96.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 100.ToBinaryArray(), 103.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .192 - .207
            var cidr = SubnetMask.FromCidrAddress("192.168.120.200", "28");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 120.ToBinaryArray(), 207.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 120.ToBinaryArray(), 192.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 120.ToBinaryArray(), 207.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .32 - .63
            var cidr = SubnetMask.FromCidrAddress("192.168.90.50", "27");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 90.ToBinaryArray(), 63.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 90.ToBinaryArray(), 32.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 90.ToBinaryArray(), 63.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .63
            var cidr = SubnetMask.FromCidrAddress("192.168.80.30", "26");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 80.ToBinaryArray(), 63.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 80.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 80.ToBinaryArray(), 63.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .127
            var cidr = SubnetMask.FromCidrAddress("192.168.70.30", "25");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 70.ToBinaryArray(), 127.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 70.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 70.ToBinaryArray(), 127.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .0 - .255
            var cidr = SubnetMask.FromCidrAddress("192.168.60.1", "24");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 60.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 60.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 60.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .50.0 - .51.255
            var cidr = SubnetMask.FromCidrAddress("192.168.50.30", "23");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 51.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 50.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 192.ToBinaryArray(), 168.ToBinaryArray(), 51.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // .16.0.0 - .16.255.255
            var cidr = SubnetMask.FromCidrAddress("172.16.40.30", "16");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 172.ToBinaryArray(), 16.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 172.ToBinaryArray(), 16.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 172.ToBinaryArray(), 16.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }

        {
            // 10.0.0.0 - 10.255.255.255
            var cidr = SubnetMask.FromCidrAddress("10.1.100.30", "8");
            var networkAddress = SubnetMask.GetNetworkAddress(cidr.Address, cidr.Subnet);
            var addressRange = SubnetMask.GetAddressRange(networkAddress, cidr.Subnet);
            var expectedBroadcast = new[] { 10.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedFirst = new[] { 10.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray(), 0.ToBinaryArray() }.SelectMany(x => x).ToArray();
            var expectedEnd = new[] { 10.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray(), 255.ToBinaryArray() }.SelectMany(x => x).ToArray();
            addressRange.BroadcastAddress.ByteArray.SequenceEqual(expectedBroadcast).Should().BeTrue();
            addressRange.FirstAddress.ByteArray.SequenceEqual(expectedFirst).Should().BeTrue();
            addressRange.EndAddress.ByteArray.SequenceEqual(expectedEnd).Should().BeTrue();
        }
    }
}

public static class SubnetExtensions
{
    /// <summary>
    /// Convert decimal int to binary array.
    /// 10 -> { 0, 0, 0, 0, 1, 0, 1, 0 }
    /// 255 -> { 1, 1, 1, 1, 1, 1, 1, 1 }
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static IEnumerable<byte> ToBinaryArray(this int num)
    {
        return Enumerable.Range(0, 8).Select(i => (num >> (7 - i)) & 1).Select(x => Convert.ToByte(x));
    }
}
