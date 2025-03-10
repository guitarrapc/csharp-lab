```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.648 μs** |   **5.3161 μs** |  **0.2914 μs** |  **6.622 μs** |  **6.371 μs** |  **6.952 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.694 μs |   8.8741 μs |  0.4864 μs |  6.717 μs |  6.196 μs |  7.168 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.675 μs |   0.5969 μs |  0.0327 μs |  5.661 μs |  5.651 μs |  5.712 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.774 μs |   9.7729 μs |  0.5357 μs |  6.021 μs |  5.160 μs |  6.141 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  7.982 μs |   9.3764 μs |  0.5140 μs |  8.086 μs |  7.424 μs |  8.436 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  6.038 μs |  13.0753 μs |  0.7167 μs |  6.001 μs |  5.340 μs |  6.772 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **41.908 μs** | **317.5099 μs** | **17.4038 μs** | **32.361 μs** | **31.369 μs** | **61.996 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 47.192 μs | 349.6347 μs | 19.1647 μs | 36.288 μs | 35.968 μs | 69.320 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 35.673 μs | 135.5598 μs |  7.4305 μs | 31.448 μs | 31.319 μs | 44.253 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 40.475 μs | 291.1488 μs | 15.9588 μs | 36.779 μs | 26.689 μs | 57.958 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.197 μs | 140.9280 μs |  7.7247 μs | 27.026 μs | 26.455 μs | 40.111 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 30.785 μs | 215.8467 μs | 11.8313 μs | 24.186 μs | 23.725 μs | 44.444 μs |   14336 B |
