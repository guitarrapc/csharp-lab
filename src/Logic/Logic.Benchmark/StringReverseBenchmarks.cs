using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringReverseBenchmarks
{
    [Params(10, 64)]
    public int Length { get; set; }
    [Params(100)]
    public int Number { get; set; }

    private string? _source;
    private StringReverse _stringReverse = new StringReverse();

    [IterationSetup]
    public void IterationSetup()
    {
        _source = StringReverse.GenerateText(Length);
    }

    [Benchmark]
    public async Task ArrayReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.ArrayReverse(_source!);
        }
    }

    [Benchmark]
    public async Task EnumerableReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.EnumerableReverse(_source!);
        }
    }

    [Benchmark]
    public async Task RecursiveReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.RecursiveReverse(_source!);
        }
    }

    [Benchmark]
    public async Task ReverseXor()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.ReverseXor(_source!);
        }
    }

    [Benchmark]
    public async Task StackReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StackReverse(_source!);
        }
    }

    [Benchmark]
    public async Task StringSpan()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StringSpan(_source!);
        }
    }

    [Benchmark]
    public async Task StringExtensionReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            _stringReverse.StringExtensionReverse(_source!);
        }
    }
}
