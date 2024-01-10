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

    [Params(1, 10)]
    public int Number { get; set; }

    [Benchmark]
    public void CidrSubnetCalculateSubnetRangeIPv6()
    {
        const int subnetMask = 64;

        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.CalculateSubnetRange(ipv6Address, subnetMask);
        }
    }

    [Benchmark]
    public void CidrSubnetCalculateSubnetRange2IPv6()
    {
        const int subnetMask = 64;

        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.CalculateSubnetRange2(ipv6Address, subnetMask);
        }
    }

    [Benchmark]
    public void CidrSubnetCalculateSubnetRangeIPv4()
    {
        const int subnetMask = 24;

        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.CalculateSubnetRange(ipv4Address, subnetMask);
        }
    }

    [Benchmark]
    public void CidrSubnetCalculateSubnetRange2IPv4()
    {
        const int subnetMask = 24;

        for (byte i = 0; i < Number; i++)
        {
            _ = CidrSubnet.CalculateSubnetRange2(ipv4Address, subnetMask);
        }
    }
}
