﻿using Strings.Core;

namespace Strings.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
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
