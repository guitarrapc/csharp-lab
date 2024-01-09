using BenchmarkDotNet.Attributes;
using Logic.Core;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringFormatBenchmarks
{
    [Params(100)]
    public int Number { get; set; }

    private readonly StringFormat _formatter = new();
    private DateTime _datetime = default!;

    [IterationSetup]
    public void IterationSetup()
    {
        _datetime = DateTime.Now;
    }

    [Benchmark]
    public void CompositeFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Composite(_datetime, "foo", i);
        }
    }

    [Benchmark]
    public void StringFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Format(_datetime, "foo", i);
        }
    }

    [Benchmark]
    public void InterpolatedFormat()
    {
        var name = "foo";
        for (var i = 0; i < Number; i++)
        {
            _ = $"{_datetime:t}: Hello, {name}! I'll give you {i} apples.";
        }
    }
}
