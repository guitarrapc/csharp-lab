using Logic.Core;
using System.ComponentModel;

namespace Logic.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class GuidMergeBenchmarks
{
    public static IEnumerable<(Guid, Guid)> TestGuidData()
    {
        yield return (Guid.NewGuid(), Guid.NewGuid());
    }


    [Benchmark]
    [ArgumentsSource(nameof(TestGuidData))]
    [Category(HashCategories.Binary)]
    public void FastMerge((Guid, Guid) data)
    {
        GuidMerge.FastMerge(data.Item1, data.Item2);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestGuidData))]
    [Category(HashCategories.String)]
    public void FairMerge((Guid, Guid) data)
    {
        GuidMerge.FairMerge(data.Item1, data.Item2);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestGuidData))]
    [Category(HashCategories.Binary)]
    public void SlowMerge((Guid, Guid) data)
    {
        GuidMerge.SlowMerge(data.Item1, data.Item2);
    }
}
