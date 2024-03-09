using BenchmarkDotNet.Attributes;
using NonAllocs.Core;

namespace Strings.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringSplitBenchmarks
{
    private static readonly string _value = string.Join(".", Enumerable.Range(0, 100).Select(x => (char)x));

    [Params(1)] // 10000 is too many
    public int Number { get; set; }

    [Benchmark]
    public void StringSplitNoAlloc()
    {
        for (var i = 0; i < Number; i++)
        {
            foreach (var _ in _value.SplitNoAlloc('.')) { }
        }
    }

    [Benchmark]
    public void StringSplit()
    {
        for (var i = 0; i < Number; i++)
        {
            foreach (var _ in _value.Split('.')) { }
        }
    }
}
