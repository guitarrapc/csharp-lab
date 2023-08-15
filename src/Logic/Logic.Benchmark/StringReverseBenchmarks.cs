using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringReverseBenchmarks
{
    [Params(1, 10, 100, 1000, 10000)]
    public int Number { get; set; }

    private readonly string _source;
    private readonly StringReverse _stringReverse;

    public StringReverseBenchmarks()
    {
        _source = StringReverse.GenerateText();
        _stringReverse = new StringReverse();
    }

    [Benchmark]
    public async Task ArrayReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.ArrayReverse(_source);
        }
    }

    [Benchmark]
    public async Task EnumerableReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.EnumerableReverse(_source);
        }
    }

    [Benchmark]
    public async Task RecursiveReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.RecursiveReverse(_source);
        }
    }

    [Benchmark]
    public async Task ReverseXor()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.ReverseXor(_source);
        }
    }

    [Benchmark]
    public async Task StackReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StackReverse(_source);
        }
    }

    [Benchmark]
    public async Task StringSpan()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StringSpan(_source);
        }
    }

    [Benchmark]
    public async Task StringExtensionReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StringExtensionReverse(_source);
        }
    }
}
