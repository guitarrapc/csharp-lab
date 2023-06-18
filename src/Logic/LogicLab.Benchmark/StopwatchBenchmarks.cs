using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StopwatchBenchmarks
{
    [Benchmark]
    public void Stopwatch()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.Elapsed.TotalSeconds;
        }
    }

    [Benchmark]
    public void ValueStopwatch()
    {
        var sw = LogicLab.ValueStopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.GetElapsedTime().TotalSeconds;
        }
    }
}
