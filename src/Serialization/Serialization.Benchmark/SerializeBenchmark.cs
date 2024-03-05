using BenchmarkDotNet.Attributes;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class SerializeBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestComplexData))]
    [Category(Categories.Complex)]
    public void SystemTextJsonComplex(HyperClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestComplexData))]
    [Category(Categories.Complex)]
    public void SystemTextJsonSourceGenComplex(HyperClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.HyperClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleData))]
    [Category(Categories.Simple)]
    public void SystemTextJsonSimple(MyClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestSimpleData))]
    [Category(Categories.Simple)]
    public void SystemTextJsonSourceGenSimple(MyClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.MyClass);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesData))]
    [Category(Categories.Primitives)]
    public void SystemTextJsonSimplePrimitives(Primitives data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestPrimitivesData))]
    [Category(Categories.Complex)]
    public void SystemTextJsonSourceGenPrimitives(Primitives data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.Primitives);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestData))]
    [Category(Categories.Primitives)]
    public void SystemTextJsonSimpleNest(NestClass data)
    {
        _ = JsonSerializer.Serialize(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestData))]
    [Category(Categories.Complex)]
    public void SystemTextJsonSourceGenNest(NestClass data)
    {
        _ = JsonSerializer.Serialize(data, SourceGenerationJsonSerializerContext.Default.NestClass);
    }
}
