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
    public void ArrayReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.ArrayReverse(_source!);
        }
    }

    [Benchmark]
    public void EnumerableReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.EnumerableReverse(_source!);
        }
    }

    [Benchmark]
    public void RecursiveReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.RecursiveReverse(_source!);
        }
    }

    [Benchmark]
    public void ReverseXor()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.ReverseXor(_source!);
        }
    }

    [Benchmark]
    public void StackReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StackReverse(_source!);
        }
    }

    [Benchmark]
    public void StringSpan()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StringSpan(_source!);
        }
    }

    [Benchmark]
    public void StringExtensionReverse()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.StringExtensionReverse(_source!);
        }
    }

    [Benchmark]
    public void TextElementEnumerator()
    {
        for (var i = 0; i < Number; i++)
        {
            StringReverse.TextElementEnumerator(_source!);
        }

    }
}
