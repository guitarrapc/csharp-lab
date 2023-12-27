using BenchmarkDotNet.Attributes;
using Logic.Networks;

namespace Logic.Benchmark.Networks;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class CidrBlockBenchmarks
{
    [Params(1, 10)]
    public int Number { get; set; }

    [Benchmark]
    public void CidrBlockNewString()
    {
        for (byte i = 0; i < Number; i++)
        {
            new CidrBlock("10.0.0.1/24");
        }
    }

    [Benchmark]
    public void CidrBlockNewBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            new CidrBlock(10, 0, 0, 1, 24);
        }
    }

    [Benchmark]
    public void CidrBlockTryParseString()
    {
        for (byte i = 0; i < Number; i++)
        {
            CidrBlock.TryParse("10.0.0.1/24", out var cidr);
        }
    }

    [Benchmark]
    public void CidrBlockTryParseBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            CidrBlock.TryParse(10, 0, 0, 1, 24, out var cidr);
        }
    }
}
