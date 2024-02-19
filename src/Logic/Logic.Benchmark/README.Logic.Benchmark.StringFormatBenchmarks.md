```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.613 μs** |   **6.915 μs** |  **0.3790 μs** |  **5.319 μs** |  **6.041 μs** |     **872 B** |
| StringFormat       | 1      |  5.848 μs |   6.408 μs |  0.3512 μs |  5.511 μs |  6.212 μs |     896 B |
| InterpolatedFormat | 1      |  6.394 μs |   2.739 μs |  0.1501 μs |  6.221 μs |  6.481 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.385 μs** | **232.449 μs** | **12.7413 μs** | **42.855 μs** | **65.096 μs** |   **14336 B** |
| StringFormat       | 100    | 37.152 μs | 128.341 μs |  7.0348 μs | 32.961 μs | 45.274 μs |   16736 B |
| InterpolatedFormat | 100    | 34.295 μs | 139.994 μs |  7.6736 μs | 29.799 μs | 43.156 μs |   14336 B |
