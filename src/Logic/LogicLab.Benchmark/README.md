# LogicLab.Benchmark

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|         Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|--------------- |---------:|---------:|--------:|---------:|---------:|----------:|
|      Stopwatch | 267.6 μs | 15.90 μs | 0.87 μs | 267.1 μs | 268.6 μs |      40 B |
| ValueStopwatch | 273.2 μs |  0.74 μs | 0.04 μs | 273.2 μs | 273.3 μs |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|         Method |    Mean |    Error |   StdDev |     Min |     Max | Allocated |
|--------------- |--------:|---------:|---------:|--------:|--------:|----------:|
|      TaskDelay | 1.199 s | 0.0096 s | 0.0005 s | 1.198 s | 1.199 s |     21 KB |
| ValueTaskDelay | 1.012 s | 0.0220 s | 0.0012 s | 1.011 s | 1.013 s |      1 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|             Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 754.5 ms | 20.02 ms | 1.10 ms | 753.2 ms | 755.4 ms |      5 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|                 Method |        Mean |       Error |      StdDev |         Min |         Max | Rank |     Gen 0 | Allocated |
|----------------------- |------------:|------------:|------------:|------------:|------------:|-----:|----------:|----------:|
|             StringSpan |    549.8 μs |    140.2 μs |     7.69 μs |    542.0 μs |    557.4 μs |    1 |   60.5469 |      1 MB |
|     ArrayReverseString |    747.7 μs |    156.8 μs |     8.60 μs |    740.5 μs |    757.2 μs |    2 |  121.0938 |      3 MB |
|             ReverseXor |  1,270.4 μs |    173.1 μs |     9.49 μs |  1,264.5 μs |  1,281.3 μs |    3 |  121.0938 |      3 MB |
|           StackReverse |  6,282.8 μs |    234.8 μs |    12.87 μs |  6,268.7 μs |  6,293.9 μs |    4 |  351.5625 |      9 MB |
| StringExtensionReverse |  7,778.0 μs |    779.3 μs |    42.72 μs |  7,728.9 μs |  7,806.1 μs |    5 |  273.4375 |      7 MB |
|      EnumerableReverse | 11,248.1 μs |    317.9 μs |    17.43 μs | 11,232.8 μs | 11,267.0 μs |    6 |  234.3750 |      6 MB |
| RecursiveStringReverse | 24,176.6 μs | 18,872.4 μs | 1,034.46 μs | 23,218.5 μs | 25,273.4 μs |    7 | 2875.0000 |     69 MB |
