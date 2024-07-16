```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.304 μs** |   **7.5746 μs** |  **0.4152 μs** |  **6.030 μs** |  **6.782 μs** |     **872 B** |
| StringFormat       | 1      |  7.230 μs |   2.4088 μs |  0.1320 μs |  7.113 μs |  7.373 μs |     896 B |
| InterpolatedFormat | 1      |  5.750 μs |   0.1824 μs |  0.0100 μs |  5.740 μs |  5.760 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.776 μs** | **126.4925 μs** |  **6.9335 μs** | **31.660 μs** | **43.782 μs** |   **14336 B** |
| StringFormat       | 100    | 37.070 μs | 148.3267 μs |  8.1303 μs | 32.351 μs | 46.458 μs |   16736 B |
| InterpolatedFormat | 100    | 47.623 μs | 206.3716 μs | 11.3119 μs | 41.027 μs | 60.685 μs |   14336 B |
