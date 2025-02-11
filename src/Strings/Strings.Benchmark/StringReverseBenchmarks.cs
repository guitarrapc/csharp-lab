using Strings.Core;

namespace Strings.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringReverseBenchmarks
{
    [Params(10, 64)]
    public int Length { get; set; }
    [Params(100)]
    public int Number { get; set; }

    private string? _source;

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
            StringReverse.ArrayReverse(_source!);
        }
    }

    [Benchmark]
    public async Task EnumerableReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.EnumerableReverse(_source!);
        }
    }

    [Benchmark]
    public async Task RecursiveReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.RecursiveReverse(_source!);
        }
    }

    [Benchmark]
    public async Task ReverseXor()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.ReverseXor(_source!);
        }
    }

    [Benchmark]
    public async Task StackReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StackReverse(_source!);
        }
    }

    [Benchmark]
    public async Task StringSpan()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StringSpan(_source!);
        }
    }

    [Benchmark]
    public async Task StringExtensionReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StringExtensionReverse(_source!);
        }
    }
}
