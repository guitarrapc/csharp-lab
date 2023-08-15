using BenchmarkDotNet.Attributes;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ValueTaskDelayBenchmarks
{
    [Benchmark]
    public async Task TaskDelay()
    {
        for (var i = 0; i < 100; i++)
        {
            await Task.Delay(10);
        }
    }

    [Benchmark]
    public async ValueTask ValueTaskDelay()
    {
        for (var i = 0; i < 100; i++)
        {
            await ValueTaskExtension.Delay(10);
        }
    }
}
