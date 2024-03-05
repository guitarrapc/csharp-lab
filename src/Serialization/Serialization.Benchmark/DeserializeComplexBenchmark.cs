using BenchmarkDotNet.Attributes;
using Serialization.Core;
using System.ComponentModel;
using System.Text.Json;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class DeserializeComplexBenchmark : BenchmarkBase
{
    [Benchmark]
    [ArgumentsSource(nameof(TestComplexJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJson(string json)
    {
        _ = JsonSerializer.Deserialize<HyperClass>(json);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestComplexJson))]
    [Category(Categories.SystemTextJson)]
    public void SystemTextJsonSourceGen(string json)
    {
        _ = JsonSerializer.Deserialize(json, SourceGenerationJsonSerializerContext.Default.HyperClass);
    }
}
