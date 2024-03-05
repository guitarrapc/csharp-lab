using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
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
