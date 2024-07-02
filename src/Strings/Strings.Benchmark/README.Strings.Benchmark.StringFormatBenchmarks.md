```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.042 μs** |  **10.254 μs** |  **0.5621 μs** |  **5.501 μs** |  **6.623 μs** |     **872 B** |
| StringFormat       | 1      |  7.598 μs |   2.645 μs |  0.1450 μs |  7.504 μs |  7.765 μs |     896 B |
| InterpolatedFormat | 1      |  6.716 μs |   1.369 μs |  0.0751 μs |  6.643 μs |  6.793 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.471 μs** | **273.923 μs** | **15.0146 μs** | **43.120 μs** | **69.790 μs** |   **14336 B** |
| StringFormat       | 100    | 45.347 μs |  14.864 μs |  0.8147 μs | 44.682 μs | 46.256 μs |   16736 B |
| InterpolatedFormat | 100    | 34.651 μs | 134.174 μs |  7.3545 μs | 30.006 μs | 43.130 μs |   14336 B |
