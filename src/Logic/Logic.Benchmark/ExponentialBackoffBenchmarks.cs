using Logic.Core;

namespace Logic.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ExponentialBackoffBenchmarks
{
    [Params(1, 10)]
    public int Number { get; set; }

    [Benchmark]
    public async Task ExponentialBackoff()
    {
        var backoff = new ExponentialBackoff(10, 100);
        for (var i = 0; i < Number; i++)
        {
            await backoff.DelayAsync();
        }
    }
}
