```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.508 μs** |   **9.1537 μs** |  **0.5017 μs** |  **5.950 μs** |  **6.922 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.555 μs |  12.2989 μs |  0.6741 μs |  6.061 μs |  7.323 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.633 μs |   3.1405 μs |  0.1721 μs |  5.440 μs |  5.770 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.995 μs |   2.0748 μs |  0.1137 μs |  5.902 μs |  6.122 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.614 μs |   0.9182 μs |  0.0503 μs |  5.561 μs |  5.661 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.932 μs |   1.1777 μs |  0.0646 μs |  4.869 μs |  4.998 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **50.392 μs** | **194.6211 μs** | **10.6678 μs** | **42.590 μs** | **62.548 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 48.901 μs |  15.1789 μs |  0.8320 μs | 48.020 μs | 49.672 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.295 μs | 114.3414 μs |  6.2674 μs | 32.572 μs | 43.531 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 31.410 μs | 175.5834 μs |  9.6243 μs | 25.293 μs | 42.504 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.932 μs | 155.8588 μs |  8.5431 μs | 26.960 μs | 41.797 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 38.625 μs | 229.1385 μs | 12.5599 μs | 24.184 μs | 47.008 μs |   14048 B |
