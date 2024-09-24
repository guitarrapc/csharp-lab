```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.144 μs** |   **1.294 μs** |  **0.0709 μs** |  **6.131 μs** |  **6.081 μs** |  **6.221 μs** |     **872 B** |
| StringFormat       | 1      |  6.686 μs |  10.571 μs |  0.5794 μs |  6.462 μs |  6.252 μs |  7.344 μs |     896 B |
| InterpolatedFormat | 1      |  6.751 μs |   5.113 μs |  0.2803 μs |  6.647 μs |  6.537 μs |  7.069 μs |     872 B |
| **CompositeFormat**    | **100**    | **42.389 μs** | **296.027 μs** | **16.2263 μs** | **33.172 μs** | **32.871 μs** | **61.125 μs** |   **14336 B** |
| StringFormat       | 100    | 50.741 μs | 201.249 μs | 11.0311 μs | 44.483 μs | 44.262 μs | 63.478 μs |   16736 B |
| InterpolatedFormat | 100    | 36.655 μs | 128.116 μs |  7.0225 μs | 32.651 μs | 32.551 μs | 44.764 μs |   14336 B |
