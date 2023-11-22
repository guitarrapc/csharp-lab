using BenchmarkDotNet.Attributes;
using Logic.Networks;

namespace Logic.Benchmark.Networks;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class SubnetMaskBenchmarks
{
    private static readonly (SubnetMask Address, SubnetMask Subnet) _cidr = SubnetMask.FromCidrAddress("192.168.150.121", "32");
    private static readonly SubnetMask _networkAddress = SubnetMask.GetNetworkAddress(_cidr.Address, _cidr.Subnet);

    [Params(1, 10, 100)]
    public int Number { get; set; }

    [Benchmark]
    public void SubnetMaskFromCidrNotion()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.FromCidrNotion(24);
        }
    }

    [Benchmark]
    public void SubnetMaskFromCidrAddress()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.FromCidrAddress("10.0.0.0/24");
        }
    }

    [Benchmark]
    public void SubnetMaskFromCidrAddress2()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.FromCidrAddress("10.0.0.0", "24");
        }
    }

    [Benchmark]
    public void SubnetMaskFromIPAddress()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.FromIPAddress("10.0.0.0");
        }
    }

    [Benchmark]
    public void SubnetMaskGetNetworkAddress()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.GetNetworkAddress(_cidr.Address, _cidr.Subnet);
        }
    }

    [Benchmark]
    public void SubnetMaskGetAddressRange()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMask.GetAddressRange(_networkAddress, _cidr.Subnet);
        }
    }
}