using BenchmarkDotNet.Attributes;
using Logic.Networks;

namespace Logic.Benchmark.Networks;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class CidrBlockv4Benchmarks
{
    [Params(1, 10)]
    public int Number { get; set; }

    [Benchmark]
    public void CidrBlockV4NewString()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = new CidrBlockv4("10.0.0.1/24");
        }
    }

    [Benchmark]
    public void CidrBlockV4NewBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = new CidrBlockv4(10, 0, 0, 1, 24);
        }
    }

    [Benchmark]
    public void CidrBlockV4TryParseString()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrBlockv4.TryParse("10.0.0.1/24", out var _);
        }
    }

    [Benchmark]
    public void CidrBlockV4TryParseBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrBlockv4.TryParse(10, 0, 0, 1, 24, out var _);
        }
    }
}
