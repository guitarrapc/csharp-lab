using BenchmarkDotNet.Attributes;
using LogicLab.Networks;

namespace LogicLab.Benchmark.Networks;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class CidrBlockBenchmarks
{
    [Benchmark]
    public void CtorString()
    {
        for (byte i = 0; i < 100; i++)
        {
            new CidrBlock("10.0.0.1/24");
        }
    }

    [Benchmark]
    public void CtorBytes()
    {
        for (byte i = 0; i < 100; i++)
        {
            new CidrBlock(10, 0, 0, 1, 24);
        }
    }

    [Benchmark]
    public void TryParseString()
    {
        for (byte i = 0; i < 100; i++)
        {
            CidrBlock.TryParse("10.0.0.1/24", out var cidr);
        }
    }

    [Benchmark]
    public void TryParseBytes()
    {
        for (byte i = 0; i < 100; i++)
        {
            CidrBlock.TryParse(10, 0, 0, 1, 24, out var cidr);
        }
    }
}
