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
public class SerializeSimpleBenchmarks : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(MyClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleData))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(MyClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.MyClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleData))]
    [Category(Categories.MemoryPack)]
    public void MemoryPack(MyClass data)
    {
        _ = MemoryPackSerializer.Serialize(data);
    }
}
