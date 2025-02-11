using Logic.Core.Networks;

namespace Logic.Benchmark.Networks;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class CidrBlockv4Benchmarks
{
    [Params(1, 3)]
    public int Number { get; set; }

    [Benchmark]
    public void NewFromCidrString()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = new CidrBlockv4("10.0.0.1/24");
        }
    }

    [Benchmark]
    public void NewFromCirBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = new CidrBlockv4(10, 0, 0, 1, 24);
        }
    }

    [Benchmark]
    public void TryParseCidrString()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrBlockv4.TryParse("10.0.0.1/24", out var _);
        }
    }

    [Benchmark]
    public void TryParseCidrBytes()
    {
        for (byte i = 0; i < Number; i++)
        {
            _ = CidrBlockv4.TryParse(10, 0, 0, 1, 24, out var _);
        }
    }
}
