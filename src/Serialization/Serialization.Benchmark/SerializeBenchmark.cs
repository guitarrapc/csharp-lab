using BenchmarkDotNet.Attributes;

namespace Serialization.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class SerializeBenchmark
{
    [Benchmark]
    public void SystemTextJson()
    {
    }

    [Benchmark]
    public void SystemTextJsonSourceGen()
    {
    }
}
