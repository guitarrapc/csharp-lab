using BenchmarkDotNet.Attributes;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class SerializeBenchmark
{
    [Params(1, 10)] // 1000 is too many
    public int Number { get; set; }

    [Benchmark]
    public void SystemTextJson()
    {
    }

    public void SystemTextJsonSourceGen()
    {
    }
}
