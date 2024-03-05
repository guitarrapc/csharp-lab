using BenchmarkDotNet.Attributes;
using NonAllocs.Core;

namespace NonAllocs.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringFormatBenchmarks
{
    [Params(1, 100)]
    public int Number { get; set; }

    private readonly StringFormat _formatter = new();
    private DateTime _datetime = default!;

    [IterationSetup]
    public void IterationSetup()
    {
        _datetime = DateTime.Now;
    }

    // good like StringInterpolated.
    [Benchmark]
    public void CompositeFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Composite(_datetime, "foo", i);
        }
    }

    // avoid if format is reusable.
    [Benchmark]
    public void StringFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Format(_datetime, "foo", i);
        }
    }

    // good.
    // C# 10.0 string interpolation use StringInterpolatedHandler pattern.
    // This removed boxing and improve performance.
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
