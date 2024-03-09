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
public class SerializePrimitivesBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(Primitives data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(Primitives data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.Primitives);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesData))]
    [Category(Categories.MemoryPack)]
    public void MemoryPack(Primitives data)
    {
        _ = MemoryPackSerializer.Serialize(data);
    }
}
