using BenchmarkDotNet.Attributes;
using LogicLab;
using System.Diagnostics;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class ExponentialBackoffBenchmarks
{
    [Benchmark]
    public async Task ExponentialBackoff()
    {
        var backoff = new ExponentialBackoff(10, 100);
        for (var i = 0; i < 10; i++)
        {
            await backoff.DelayAsync();
        }
    }
}

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StopwatchBenchmarks
{
    [Benchmark]
    public void Stopwatch()
    {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.Elapsed.TotalSeconds;
        }
    }

    [Benchmark]
    public void ValueStopwatch()
    {
        var sw = ValueStopwatch.StartNew();
        for (var i = 0; i < 10000; i++)
        {
            _ = sw.GetElapsedTime().TotalSeconds;
        }
    }
}

[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class StringReverseBenchmarks
{
    private readonly string _source;
    private readonly StringReverse _stringReverse;

    public StringReverseBenchmarks()
    {
        _source = StringReverse.GenerateText();
        _stringReverse = new StringReverse();
    }

    [Benchmark]
    public async Task ArrayReverseString()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.ArrayReverseString(_source);
        }
    }

    [Benchmark]
    public async Task EnumerableReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.EnumerableReverse(_source);
        }
    }

    [Benchmark]
    public async Task RecursiveStringReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.RecursiveStringReverse(_source);
        }
    }

    [Benchmark]
    public async Task ReverseXor()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.ReverseXor(_source);
        }
    }

    [Benchmark]
    public async Task StackReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StackReverse(_source);
        }
    }

    [Benchmark]
    public async Task StringSpan()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StringSpan(_source);
        }
    }

    [Benchmark]
    public async Task StringExtensionReverse()
    {
        for (var i = 0; i < 10000; i++)
        {
            _stringReverse.StringExtensionReverse(_source);
        }
    }
}

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
