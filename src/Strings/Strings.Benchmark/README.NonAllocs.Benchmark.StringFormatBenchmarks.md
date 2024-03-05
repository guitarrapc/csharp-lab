```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.947 μs** |  **11.0777 μs** |  **0.6072 μs** |  **6.283 μs** |  **7.474 μs** |     **872 B** |
| StringFormat       | 1      |  6.356 μs |   0.8938 μs |  0.0490 μs |  6.323 μs |  6.412 μs |     896 B |
| InterpolatedFormat | 1      |  5.898 μs |   1.5405 μs |  0.0844 μs |  5.801 μs |  5.952 μs |     872 B |
| **CompositeFormat**    | **100**    | **66.853 μs** | **214.7298 μs** | **11.7701 μs** | **57.810 μs** | **80.161 μs** |   **14336 B** |
| StringFormat       | 100    | 53.389 μs | 259.8009 μs | 14.2406 μs | 44.549 μs | 69.817 μs |   16736 B |
| InterpolatedFormat | 100    | 42.547 μs |   9.7860 μs |  0.5364 μs | 41.999 μs | 43.072 μs |   14336 B |
