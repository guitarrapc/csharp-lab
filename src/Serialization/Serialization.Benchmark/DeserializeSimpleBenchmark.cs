using BenchmarkDotNet.Attributes;
using MemoryPack;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class DeserializeSimpleBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(string json)
    {
        _ = JsonSerializer.Deserialize<MyClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.MyClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleMemoryPack))]
    [Category(Categories.MemoryPack)]
    public void MemoryPack(byte[] data)
    {
        _ = MemoryPackSerializer.Deserialize<MyClass>(data);
    }
}
