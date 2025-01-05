```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.704 μs** |  **12.9269 μs** |  **0.7086 μs** |  **5.310 μs** |  **5.280 μs** |  **6.522 μs** |     **872 B** |
| StringFormat       | 1      |  6.302 μs |   0.7389 μs |  0.0405 μs |  6.301 μs |  6.261 μs |  6.343 μs |     896 B |
| InterpolatedFormat | 1      |  5.870 μs |  11.9231 μs |  0.6535 μs |  5.930 μs |  5.189 μs |  6.492 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.179 μs** | **209.4152 μs** | **11.4788 μs** | **37.063 μs** | **36.053 μs** | **56.420 μs** |   **14048 B** |
| StringFormat       | 100    | 34.904 μs | 207.3643 μs | 11.3663 μs | 28.372 μs | 28.312 μs | 48.029 μs |   16736 B |
| InterpolatedFormat | 100    | 36.566 μs | 352.2336 μs | 19.3071 μs | 25.990 μs | 24.857 μs | 58.850 μs |   14336 B |
