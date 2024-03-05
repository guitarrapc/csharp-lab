using BenchmarkDotNet.Attributes;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class DeserializeBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestComplexJson))]
    [Category(Categories.Complex)]
    public void SystemTextJson(string json)
    {
        _ = JsonSerializer.Deserialize<HyperClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestComplexJson))]
    [Category(Categories.Complex)]
    public void SystemTextJsonSourceGen(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.HyperClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleJson))]
    [Category(Categories.Simple)]
    public void SystemTextJsonSimple(string json)
    {
        _ = JsonSerializer.Deserialize<MyClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleJson))]
    [Category(Categories.Simple)]
    public void SystemTextJsonSourceGenSimple(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.MyClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesJson))]
    [Category(Categories.Primitives)]
    public void SystemTextJsonSimplePrimitives(string json)
    {
        _ = JsonSerializer.Deserialize<Primitives>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesJson))]
    [Category(Categories.Primitives)]
    public void SystemTextJsonSourceGenPrimitives(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.Primitives);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestJson))]
    [Category(Categories.Nest)]
    public void SystemTextJsonSimpleNest(string json)
    {
        _ = JsonSerializer.Deserialize<NestClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestJson))]
    [Category(Categories.Nest)]
    public void SystemTextJsonSourceGenNest(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.NestClass);
    }
}
