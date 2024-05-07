```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.220 μs** |   **1.7056 μs** | **0.0935 μs** |  **6.157 μs** |  **6.327 μs** |     **872 B** |
| StringFormat       | 1      |  6.135 μs |   0.4591 μs | 0.0252 μs |  6.112 μs |  6.162 μs |     896 B |
| InterpolatedFormat | 1      |  6.175 μs |   4.5711 μs | 0.2506 μs |  5.921 μs |  6.423 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.644 μs** | **129.3396 μs** | **7.0895 μs** | **31.249 μs** | **43.823 μs** |   **14336 B** |
| StringFormat       | 100    | 37.000 μs | 133.2868 μs | 7.3059 μs | 32.742 μs | 45.436 μs |   16736 B |
| InterpolatedFormat | 100    | 41.148 μs |  21.3913 μs | 1.1725 μs | 39.996 μs | 42.340 μs |   14336 B |
