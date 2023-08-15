using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StopwatchBenchmarks
{
    [Params(1, 10, 100, 1000, 10000)]
    public int Number { get; set; }

    [Benchmark]
    public void Stopwatch()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (var i = 0; i < Number; i++)
        {
            _ = sw.Elapsed.TotalSeconds;
        }
    }

    [Benchmark]
    public void ValueStopwatch()
    {
        var sw = Logic.ValueStopwatch.StartNew();
        for (var i = 0; i < Number; i++)
        {
            _ = sw.GetElapsedTime().TotalSeconds;
        }
    }
}
