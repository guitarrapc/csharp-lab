using BenchmarkDotNet.Attributes;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class DeserializeNestBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestNestJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(string json)
    {
        _ = JsonSerializer.Deserialize<NestClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestNestJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.NestClass);
    }

    // MemoryPack not support Nested Class
}
