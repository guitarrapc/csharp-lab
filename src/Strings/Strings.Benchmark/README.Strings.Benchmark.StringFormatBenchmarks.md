```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.280 μs** |   **1.665 μs** |  **0.0913 μs** |  **6.197 μs** |  **6.378 μs** |     **872 B** |
| StringFormat       | 1      |  6.665 μs |  10.339 μs |  0.5667 μs |  6.020 μs |  7.083 μs |     896 B |
| InterpolatedFormat | 1      |  5.830 μs |   1.264 μs |  0.0693 μs |  5.750 μs |  5.870 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.185 μs** | **128.849 μs** |  **7.0626 μs** | **31.820 μs** | **44.333 μs** |   **14336 B** |
| StringFormat       | 100    | 36.831 μs | 136.866 μs |  7.5021 μs | 32.500 μs | 45.494 μs |   16736 B |
| InterpolatedFormat | 100    | 48.353 μs | 203.608 μs | 11.1604 μs | 41.357 μs | 61.224 μs |   14336 B |
