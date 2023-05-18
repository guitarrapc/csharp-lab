using BenchmarkDotNet.Attributes;
using LogicLab;
using System.Diagnostics;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StopwatchBenchmarks
{
    [Benchmark]
    public void StopwatchDefault()
    {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.Elapsed.TotalSeconds;
        }
    }

    [Benchmark]
    public void StopwatchValue()
    {
        var sw = ValueStopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.GetElapsedTime().TotalSeconds;
        }
    }
}

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
