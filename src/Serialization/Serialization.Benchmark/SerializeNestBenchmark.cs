using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[HideColumns(Column.Job, Column.RatioSD, Column.AllocRatio)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class SerializeNestBenchmarks : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestNestData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(NestClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(NestClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.NestClass);
    }

    // MemoryPack not support Nested Class
}
