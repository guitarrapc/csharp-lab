using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringSplitBenchmarks
{
    private readonly string _value = string.Join(".", Enumerable.Range(0, 100).Select(x => (char)x));

    [Benchmark]
    public void StringSplitNoAlloc()
    {
        for (var i = 0; i < 10000; i++)
        {
            foreach (var _ in _value.SplitNoAlloc('.')) { }
        }
    }

    [Benchmark]
    public void StringSplit()
    {
        for (var i = 0; i < 10000; i++)
        {
            foreach (var _ in _value.Split('.')) { }
        }
    }
}
