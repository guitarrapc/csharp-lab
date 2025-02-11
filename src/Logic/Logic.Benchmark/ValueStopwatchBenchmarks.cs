namespace Logic.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ValueStopwatchBenchmarks
{
    [Params(1, 3)] // 1000 is too many
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
        var sw = Logic.Core.ValueStopwatch.StartNew();
        for (var i = 0; i < Number; i++)
        {
            _ = sw.GetElapsedTime().TotalSeconds;
        }
    }
}
