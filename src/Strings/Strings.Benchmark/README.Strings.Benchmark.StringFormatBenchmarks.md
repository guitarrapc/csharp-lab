```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.051 μs** |   **0.5565 μs** |  **0.0305 μs** |  **6.020 μs** |  **6.081 μs** |     **872 B** |
| StringFormat       | 1      |  6.732 μs |   4.2991 μs |  0.2356 μs |  6.492 μs |  6.963 μs |     896 B |
| InterpolatedFormat | 1      |  6.045 μs |   1.8455 μs |  0.1012 μs |  5.982 μs |  6.162 μs |     872 B |
| **CompositeFormat**    | **100**    | **41.567 μs** | **251.8445 μs** | **13.8044 μs** | **33.592 μs** | **57.507 μs** |   **14336 B** |
| StringFormat       | 100    | 38.077 μs | 152.4252 μs |  8.3549 μs | 32.951 μs | 47.718 μs |   16736 B |
| InterpolatedFormat | 100    | 34.537 μs | 122.4217 μs |  6.7103 μs | 30.386 μs | 42.279 μs |   14336 B |
