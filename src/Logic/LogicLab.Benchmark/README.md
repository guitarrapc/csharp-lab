# LoggerBenchmark

Environment

```
// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
AMD Ryzen 9 7950X3D, 1 CPU, 32 logical and 16 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3
```

## Exponential Backoff

10 runs.

|             Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 840.4 ms | 16.75 ms | 0.92 ms | 839.6 ms | 841.4 ms |      8 KB |


## Stopwatch and ValueStopwatch

10000 runs.

|           Method |     Mean |   Error |  StdDev |      Min |      Max | Allocated |
|----------------- |---------:|--------:|--------:|---------:|---------:|----------:|
| StopwatchDefault | 149.2 us | 0.96 us | 0.05 us | 149.2 us | 149.2 us |      40 B |
|   StopwatchValue | 147.4 us | 2.37 us | 0.13 us | 147.3 us | 147.5 us |         - |
