using BenchmarkDotNet.Attributes;

namespace LogicLab.Benchmark;

[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringReverseBenchmarks
{
    private readonly string _source;
    private readonly StringReverse _stringReverse;

    public StringReverseBenchmarks()
    {
        _source = StringReverse.GenerateText();
        _stringReverse = new StringReverse();
    }

    [Benchmark]
    public async Task ArrayReverseString()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.ArrayReverseString(_source);
        }
    }

    [Benchmark]
    public async Task EnumerableReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.EnumerableReverse(_source);
        }
    }

    [Benchmark]
    public async Task RecursiveStringReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.RecursiveStringReverse(_source);
        }
    }

    [Benchmark]
    public async Task ReverseXor()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.ReverseXor(_source);
        }
    }

    [Benchmark]
    public async Task StackReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StackReverse(_source);
        }
    }

    [Benchmark]
    public async Task StringSpan()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StringSpan(_source);
        }
    }

    [Benchmark]
    public async Task StringExtensionReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StringExtensionReverse(_source);
        }
    }
}
