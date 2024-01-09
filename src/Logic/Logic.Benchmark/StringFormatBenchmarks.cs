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

    private readonly StringFormat _formatter = new("Hello, {0}! I'll give you {1} apples.");

    [Benchmark]
    public void CompositeFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Composite("foo", i);
        }
    }

    [Benchmark]
    public void StringFormat()
    {
        for (var i = 0; i < Number; i++)
        {
            _formatter.Format("foo", i);
        }
    }

}
