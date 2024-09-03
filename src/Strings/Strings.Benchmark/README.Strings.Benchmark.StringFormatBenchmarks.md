```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **7.034 μs** |   **3.820 μs** |  **0.2094 μs** |  **6.793 μs** |  **7.174 μs** |     **872 B** |
| StringFormat       | 1      |  6.881 μs |   7.154 μs |  0.3921 μs |  6.537 μs |  7.309 μs |     896 B |
| InterpolatedFormat | 1      |  6.341 μs |   3.040 μs |  0.1666 μs |  6.151 μs |  6.461 μs |     872 B |
| **CompositeFormat**    | **100**    | **59.558 μs** | **269.923 μs** | **14.7954 μs** | **50.525 μs** | **76.633 μs** |   **14336 B** |
| StringFormat       | 100    | 47.432 μs | 151.277 μs |  8.2920 μs | 38.432 μs | 54.762 μs |   16736 B |
| InterpolatedFormat | 100    | 46.824 μs |  35.329 μs |  1.9365 μs | 45.294 μs | 49.001 μs |   14336 B |
