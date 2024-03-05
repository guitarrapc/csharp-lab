using BenchmarkDotNet.Attributes;
using Logic.Networks;
using System.Net;

namespace Logic.Benchmark.Networks;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class CidrSubnetBenchmarks
{
    private readonly IPAddress ipv6Address = IPAddress.Parse("2001:0db8:0001:0000:0000:0ab9:C0A8:0102");
    private readonly IPAddress ipv4Address = IPAddress.Parse("192.168.10.100");

    [Params(1, 3)]
    public int Number { get; set; }

    // GetNthSubnet
    [Benchmark]
    public void GetNthSubnetIPv6()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetNthSubnet(ipv6Address, 64, 8, 2 * i);
        }
    }

    [Benchmark]
    public void GetNthSubnetIPv4()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetNthSubnet(ipv4Address, 24, 8, 2 * i);
        }
    }

    // GetSubnetRange
    [Benchmark]
    public void GetSubnetRangeIPv6BigInteger()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetSubnetRangeSlow(ipv6Address, 64);
        }
    }

    [Benchmark]
    public void GetSubnetRangeIPv6Shift()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetSubnetRange(ipv6Address, 64);
        }
    }

    [Benchmark]
    public void GetSubnetRangeIPv4BigInteger()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetSubnetRangeSlow(ipv4Address, 24);
        }
    }

    [Benchmark]
    public void GetSubnetRangeIPv4Shift()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.GetSubnetRange(ipv4Address, 24);
        }
    }
}
