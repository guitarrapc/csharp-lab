using BenchmarkDotNet.Attributes;
using MemoryPack;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class DeserializePrimitivesBenchmarks : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(string json)
    {
        _ = JsonSerializer.Deserialize<Primitives>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.Primitives);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesMemoryPack))]
    [Category(Categories.MemoryPack)]
    public void MemoryPack(byte[] data)
    {
        _ = MemoryPackSerializer.Deserialize<Primitives>(data);
    }
}
