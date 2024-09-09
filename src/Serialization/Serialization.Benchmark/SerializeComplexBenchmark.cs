using BenchmarkDotNet.Attributes;
using MemoryPack;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class SerializeComplexBenchmarks : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestComplexData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(HyperClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestComplexData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(HyperClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.HyperClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestComplexData))]
    [Category(Categories.MemoryPack)]
    public void MemoryPack(HyperClass data)
    {
        _ = MemoryPackSerializer.Serialize(data);
    }
}
