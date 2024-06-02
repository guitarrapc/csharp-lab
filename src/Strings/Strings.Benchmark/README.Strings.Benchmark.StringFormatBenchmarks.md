```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.835 μs** |   **4.7057 μs** |  **0.2579 μs** |  **5.701 μs** |  **5.671 μs** |  **6.132 μs** |     **872 B** |
| StringFormat       | 1      |  7.220 μs |   2.6584 μs |  0.1457 μs |  7.173 μs |  7.103 μs |  7.383 μs |     896 B |
| InterpolatedFormat | 1      |  5.660 μs |   0.7848 μs |  0.0430 μs |  5.640 μs |  5.630 μs |  5.709 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.286 μs** | **145.5281 μs** |  **7.9769 μs** | **32.770 μs** | **32.591 μs** | **46.496 μs** |   **14336 B** |
| StringFormat       | 100    | 44.935 μs | 362.9818 μs | 19.8963 μs | 33.623 μs | 33.273 μs | 67.908 μs |   16736 B |
| InterpolatedFormat | 100    | 49.121 μs | 215.0246 μs | 11.7862 μs | 42.849 μs | 41.797 μs | 62.718 μs |   14336 B |
