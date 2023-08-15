using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ExponentialBackoffBenchmarks
{
    [Benchmark]
    public async Task ExponentialBackoff()
    {
        var backoff = new ExponentialBackoff(10, 100);
        for (var i = 0; i < 10; i++)
        {
            await backoff.DelayAsync();
        }
    }
}
