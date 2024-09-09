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
| **CompositeFormat**    | **1**      |  **6.502 μs** |  **12.479 μs** |  **0.6840 μs** |  **6.011 μs** |  **7.283 μs** |     **872 B** |
| StringFormat       | 1      |  6.225 μs |   2.646 μs |  0.1450 μs |  6.082 μs |  6.372 μs |     896 B |
| InterpolatedFormat | 1      |  6.191 μs |   5.018 μs |  0.2751 μs |  5.891 μs |  6.431 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.644 μs** | **273.924 μs** | **15.0147 μs** | **43.761 μs** | **69.980 μs** |   **13664 B** |
| StringFormat       | 100    | 37.429 μs | 144.773 μs |  7.9355 μs | 32.560 μs | 46.586 μs |   16736 B |
| InterpolatedFormat | 100    | 36.262 μs | 163.374 μs |  8.9551 μs | 30.942 μs | 46.601 μs |   14336 B |
