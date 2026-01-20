using Logic.Core.Networks;

namespace Logic.Tests.Networks;

public class CidrMergerv4Test
{
    [Theory]
    [InlineData(new[] { "192.168.0.0/27", "192.168.0.32/27", "192.168.0.64/27", "192.168.0.96/27", "192.168.0.128/27", "192.168.0.160/27", "192.168.0.192/27", "192.168.0.224/27", }, new[] { "192.168.0.0/24" })]
    [InlineData(new[] { "192.168.0.0/22", "192.168.4.0/22", "192.168.8.0/22", "192.168.12.0/22" }, new[] { "192.168.0.0/20" })]
    [InlineData(new[] { "192.168.0.0/24", "192.168.1.0/24", "192.168.2.0/24", "192.168.3.0/24", "192.168.4.0/24", "192.168.5.0/24", "192.168.6.0/24", "192.168.7.0/24" }, new[] { "192.168.0.0/21" })]
    [InlineData(new[] { "192.168.0.0/24", "192.168.1.0/24", "192.168.2.0/24", "192.168.3.0/24" }, new[] { "192.168.0.0/22" })]
    [InlineData(new[] { "192.168.0.0/24", "192.168.1.0/24", }, new[] { "192.168.0.0/23" })]
    [InlineData(new[] { "10.0.0.0/23", "10.0.2.0/23", }, new[] { "10.0.0.0/22" })]
    [InlineData(new[] { "10.0.0.0/22", "10.0.4.0/22", }, new[] { "10.0.0.0/21" })]
    [InlineData(new[] { "10.0.0.0/21", "10.0.8.0/21", }, new[] { "10.0.0.0/20" })]
    [InlineData(new[] { "10.0.0.0/20", "10.0.16.0/20", }, new[] { "10.0.0.0/19" })]
    [InlineData(new[] { "10.0.0.0/19", "10.0.32.0/19", }, new[] { "10.0.0.0/18" })]
    [InlineData(new[] { "10.0.0.0/18", "10.0.64.0/18", }, new[] { "10.0.0.0/17" })]
    [InlineData(new[] { "10.0.0.0/17", "10.0.128.0/17", }, new[] { "10.0.0.0/16" })]
    public void SimpleMergeTest(IEnumerable<string> source, IEnumerable<string> expected)
    {
        var merged = CidrMergerv4.CollapseAddresses(source);
        Assert.Equal(expected, merged);
    }

    [Theory]
    [InlineData(new[] { "192.168.0.0/24", "192.168.2.0/24", }, new[] { "192.168.0.0/24", "192.168.2.0/24" })]
    [InlineData(new[] { "192.168.0.0/24", "192.168.3.0/24", "192.168.4.0/24", "192.168.5.0/24" }, new[] { "192.168.0.0/24", "192.168.3.0/24", "192.168.4.0/23" })]
    public void NoneMergeTest(IEnumerable<string> source, IEnumerable<string> expected)
    {
        var merged = CidrMergerv4.CollapseAddresses(source);
        Assert.Equal(expected, merged);
    }

    [Fact]
    public void ComplexMergeTest()
    {
        var sampleSource = new[]
        {
            "192.168.0.0/27",
            "192.168.0.32/27",
            "192.168.0.64/27",
            "192.168.0.96/27",
            "192.168.0.128/27",
            "192.168.0.160/27",
            "192.168.0.192/27",
            "192.168.0.224/27",
            "192.168.1.0/27",
            "192.168.1.32/27",
            "192.168.1.96/27",
            "192.168.2.0/28",
            "192.168.2.16/28",
            "192.168.2.32/28",
            "192.168.2.48/28",
            "192.168.2.64/28",
            "192.168.3.0/26",
            "192.168.3.64/26",
            "192.168.3.128/26",
            "192.168.3.192/26",
            "10.0.0.0/24",
            "10.0.2.0/24",
            "10.0.4.0/24",
            "10.0.6.0/24",
            "172.16.0.0/25",
            "172.16.0.128/25",
            "192.0.2.0/26",
            "192.0.2.64/26",
            "203.0.113.0/27",
            "203.0.113.32/27",
            "198.51.100.0/28",
            "198.51.100.16/28",
            "198.51.100.32/28",
            "198.51.100.48/28",
            "8.8.8.0/24",
            "8.8.10.0/24",
            "192.168.100.0/26",
            "192.168.100.64/26",
            "192.168.100.128/26",
            "192.168.100.192/26",
            "192.168.101.0/27",
            "192.168.101.32/27",
            "192.168.101.64/27",
            "192.168.101.96/27",
            "192.168.101.128/27",
            "10.1.0.0/24",
            "10.1.1.0/24",
            "10.1.2.0/24",
            "172.16.1.0/25",
            "172.16.1.128/25",
            "192.168.50.0/27",
            "192.168.50.32/27",
            "192.168.50.64/27",
            "192.168.50.96/27",
            "203.0.113.64/27",
            "203.0.113.96/27",
            "203.0.113.128/27",
            "203.0.113.160/27",
            "203.0.113.192/27",
            "203.0.113.224/27",
            "198.51.100.64/28",
            "198.51.100.80/28",
            "198.51.100.96/28",
            "198.51.100.112/28",
            "8.8.4.0/24",
            "8.8.5.0/24",
            "1.1.1.0/24",
            "1.1.2.0/24",
            "1.1.3.0/24",
            "9.9.9.0/28",
            "9.9.9.16/28",
            "9.9.9.32/28",
            "9.9.9.48/28",
            "192.168.200.0/25",
            "192.168.200.128/25",
            "192.168.201.0/26",
            "192.168.201.64/26",
            "192.168.201.128/26",
            "192.168.201.192/26",
            "192.168.202.0/27",
            "192.168.202.32/27",
            "192.168.202.64/27",
            "192.168.202.96/27",
            "192.168.202.128/27",
            "192.168.202.160/27",
            "192.168.202.192/27",
            "192.168.202.224/27",
            "172.31.0.0/24",
            "172.31.1.0/24",
            "172.31.2.0/24",
            "172.31.3.0/24",
            "192.168.250.0/25",
            "192.168.250.128/25",
            "192.168.251.0/26",
            "192.168.251.64/26",
            "192.168.251.128/26",
            "192.168.251.192/26",
            "192.168.252.0/24",
            "192.168.253.0/24",
            "192.168.254.0/24",
        };
        var expected = new[]
        {
            "1.1.1.0/24",
            "1.1.2.0/23",
            "8.8.4.0/23",
            "8.8.8.0/24",
            "8.8.10.0/24",
            "9.9.9.0/26",
            "10.0.0.0/24",
            "10.0.2.0/24",
            "10.0.4.0/24",
            "10.0.6.0/24",
            "10.1.0.0/23",
            "10.1.2.0/24",
            "172.16.0.0/23",
            "172.31.0.0/22",
            "192.0.2.0/25",
            "192.168.0.0/24",
            "192.168.1.0/26",
            "192.168.1.96/27",
            "192.168.2.0/26",
            "192.168.2.64/28",
            "192.168.3.0/24",
            "192.168.50.0/25",
            "192.168.100.0/24",
            "192.168.101.0/25",
            "192.168.101.128/27",
            "192.168.200.0/23",
            "192.168.202.0/24",
            "192.168.250.0/23",
            "192.168.252.0/23",
            "192.168.254.0/24",
            "198.51.100.0/25",
            "203.0.113.0/24",
        };
        var merged = CidrMergerv4.CollapseAddresses(sampleSource);
        Assert.Equal(expected, merged);
    }

    [Fact]
    public void EdgeCase_EmptyInput()
    {
        var merged = CidrMergerv4.CollapseAddresses([]);
        Assert.Empty(merged);
    }

    [Fact]
    public void EdgeCase_SingleCidr()
    {
        var merged = CidrMergerv4.CollapseAddresses(["192.168.1.0/24"]);
        Assert.Equal(["192.168.1.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_DuplicateCidrs()
    {
        var merged = CidrMergerv4.CollapseAddresses(["192.168.1.0/24", "192.168.1.0/24", "192.168.1.0/24"]);
        Assert.Equal(["192.168.1.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_FullIPv4Space()
    {
        var merged = CidrMergerv4.CollapseAddresses(["0.0.0.0/0"]);
        Assert.Equal(["0.0.0.0/0"], merged);
    }

    [Fact]
    public void EdgeCase_EntireIPv4SpaceFromHalves()
    {
        var merged = CidrMergerv4.CollapseAddresses(["0.0.0.0/1", "128.0.0.0/1"]);
        Assert.Equal(["0.0.0.0/0"], merged);
    }

    [Fact]
    public void EdgeCase_OverlappingRanges()
    {
        // 192.168.0.0/24 contains 192.168.0.0/25
        var merged = CidrMergerv4.CollapseAddresses(["192.168.0.0/24", "192.168.0.0/25"]);
        Assert.Equal(["192.168.0.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_NonContiguousBlocks()
    {
        var merged = CidrMergerv4.CollapseAddresses(["192.168.0.0/24", "192.168.2.0/24", "192.168.4.0/24"]);
        Assert.Equal(["192.168.0.0/24", "192.168.2.0/24", "192.168.4.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_UnalignedMerge()
    {
        // These should merge into optimal CIDR blocks
        var merged = CidrMergerv4.CollapseAddresses(["192.168.1.0/25", "192.168.1.128/25"]);
        Assert.Equal(["192.168.1.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_HighestAddressRange()
    {
        var merged = CidrMergerv4.CollapseAddresses(["255.255.255.0/24"]);
        Assert.Equal(["255.255.255.0/24"], merged);
    }

    [Fact]
    public void EdgeCase_MaximumPrefixLength()
    {
        var merged = CidrMergerv4.CollapseAddresses(["192.168.1.1/32", "192.168.1.2/32"]);
        Assert.Equal(["192.168.1.1/32", "192.168.1.2/32"], merged);
    }

    [Fact]
    public void EdgeCase_AdjacentSingleHosts()
    {
        var merged = CidrMergerv4.CollapseAddresses(["192.168.1.0/32", "192.168.1.1/32"]);
        Assert.Equal(["192.168.1.0/31"], merged);
    }

    [Theory]
    [InlineData("192.168.1.0/33")]
    [InlineData("192.168.1.0/-1")]
    [InlineData("192.168.1.0/abc")]
    public void Validation_InvalidPrefixLength(string invalidCidr)
    {
        Assert.Throws<ArgumentException>(() => CidrMergerv4.CollapseAddresses([invalidCidr]));
    }

    [Fact]
    public void Validation_InvalidCidrFormat()
    {
        Assert.Throws<ArgumentException>(() => CidrMergerv4.CollapseAddresses(["192.168.1.0"]));
        Assert.Throws<ArgumentException>(() => CidrMergerv4.CollapseAddresses(["192.168.1.0/24/32"]));
    }

    [Fact]
    public void Validation_IPv6ShouldFail()
    {
        Assert.Throws<ArgumentException>(() => CidrMergerv4.CollapseAddresses(["2001:db8::/32"]));
    }

    [Fact]
    public void Performance_LargeNumberOfSmallBlocks()
    {
        // Generate 256 /32 blocks that should merge into /24
        var cidrs = Enumerable.Range(0, 256).Select(i => $"192.168.1.{i}/32").ToList();
        var merged = CidrMergerv4.CollapseAddresses(cidrs);
        Assert.Equal(["192.168.1.0/24"], merged);
    }

    [Fact]
    public void RangeToCIDRs_UnalignedRange()
    {
        // Test a range that doesn't start on a power-of-2 boundary
        // 192.168.1.5 to 192.168.1.10 should split into optimal blocks
        var merged = CidrMergerv4.CollapseAddresses([
            "192.168.1.5/32",
            "192.168.1.6/32",
            "192.168.1.7/32",
            "192.168.1.8/32",
            "192.168.1.9/32",
            "192.168.1.10/32"
        ]);
        
        // Expected: optimal split considering alignment
        // 192.168.1.5/32, 192.168.1.6/31, 192.168.1.8/31, 192.168.1.10/32
        Assert.Equal([
            "192.168.1.5/32",
            "192.168.1.6/31",
            "192.168.1.8/31",
            "192.168.1.10/32"
        ], merged);
    }
}
