using BenchmarkDotNet.Attributes;
using Logic.Core;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ValueTaskDelayBenchmarks
{
    [Params(1)] // 100 is too many
    public int Number { get; set; }

    [Benchmark]
    public async Task TaskDelay()
    {
        for (var i = 0; i < Number; i++)
        {
            await Task.Delay(10);
        }
    }

    [Benchmark]
    public async ValueTask ValueTaskDelay()
    {
        for (var i = 0; i < Number; i++)
        {
            await ValueTaskExtension.Delay(10);
        }
    }
}
