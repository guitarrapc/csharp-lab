using BenchmarkDotNet.Attributes;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class SerializeNestBenchmark : BenchmarkBase
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
}
