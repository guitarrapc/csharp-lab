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

## ExponentialBackoff

10 runs.

|             Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 840.4 ms | 16.75 ms | 0.92 ms | 839.6 ms | 841.4 ms |      8 KB |


## Stopwatch

10000 runs.

|           Method |     Mean |   Error |  StdDev |      Min |      Max | Allocated |
|----------------- |---------:|--------:|--------:|---------:|---------:|----------:|
| StopwatchDefault | 149.2 us | 0.96 us | 0.05 us | 149.2 us | 149.2 us |      40 B |
|   StopwatchValue | 147.4 us | 2.37 us | 0.13 us | 147.3 us | 147.5 us |         - |

## StringReverse

10000 runs.

|                 Method |       Mean |       Error |   StdDev |        Min |        Max | Rank |     Gen 0 | Allocated |
|----------------------- |-----------:|------------:|---------:|-----------:|-----------:|-----:|----------:|----------:|
|             StringSpan |   266.7 us |    10.73 us |  0.59 us |   266.2 us |   267.3 us |    1 |   30.2734 |      1 MB |
|     ArrayReverseString |   297.6 us |   143.95 us |  7.89 us |   291.8 us |   306.6 us |    2 |   60.5469 |      3 MB |
|             ReverseXor |   508.4 us |   267.05 us | 14.64 us |   498.9 us |   525.2 us |    3 |   60.5469 |      3 MB |
|           StackReverse | 2,578.4 us |   432.21 us | 23.69 us | 2,555.7 us | 2,603.0 us |    4 |  175.7813 |      9 MB |
| StringExtensionReverse | 3,367.0 us |   229.07 us | 12.56 us | 3,353.1 us | 3,377.5 us |    5 |  136.7188 |      7 MB |
|      EnumerableReverse | 5,381.7 us | 1,096.77 us | 60.12 us | 5,319.5 us | 5,439.5 us |    6 |  117.1875 |      6 MB |
| RecursiveStringReverse | 8,865.1 us | 1,610.13 us | 88.26 us | 8,793.1 us | 8,963.6 us |    7 | 1437.5000 |     69 MB 
