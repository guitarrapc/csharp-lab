using Logic.Core.Networks;
using System.Net;

namespace Logic.Benchmark.Networks;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class SubnetMaskv4Benchmarks
{
    private static readonly (SubnetMaskv4 Address, SubnetMaskv4 Subnet) _cidr = SubnetMaskv4.FromCidr("192.168.150.121", "32");
    private static readonly SubnetMaskv4 _networkAddress = SubnetMaskv4.GetNetworkAddress(_cidr.Address, _cidr.Subnet);
    private readonly IPAddress _ipaddress = IPAddress.Parse("10.0.0.0");

    [Params(1, 3)]
    public int Number { get; set; }

    [Benchmark]
    public void FromPrefix()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.FromPrefix(24);
        }
    }

    [Benchmark]
    public void FromCidrAddress()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.FromCidr("10.0.0.0/24");
        }
    }

    [Benchmark]
    public void FromCidrAddress2()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.FromCidr("10.0.0.0", "24");
        }
    }

    [Benchmark]
    public void FromIPAddressString()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.FromIPAddress("10.0.0.0");
        }
    }

    [Benchmark]
    public void FromIPAddressType()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.FromIPAddress(_ipaddress);
        }
    }

    [Benchmark]
    public void GetNetworkAddress()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.GetNetworkAddress(_cidr.Address, _cidr.Subnet);
        }
    }

    [Benchmark]
    public void GetAddressRange()
    {
        for (byte i = 0; i < Number; i++)
        {
            SubnetMaskv4.GetAddressRange(_networkAddress, _cidr.Subnet);
        }
    }
}
