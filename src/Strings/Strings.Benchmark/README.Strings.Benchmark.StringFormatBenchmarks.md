```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.879 μs** |   **9.613 μs** |  **0.5269 μs** |  **6.792 μs** |  **6.401 μs** |  **7.444 μs** |     **872 B** |
| StringFormat       | 1      |  6.584 μs |  11.505 μs |  0.6306 μs |  6.457 μs |  6.026 μs |  7.268 μs |     896 B |
| InterpolatedFormat | 1      |  5.992 μs |   2.465 μs |  0.1351 μs |  5.952 μs |  5.882 μs |  6.143 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.400 μs** | **218.529 μs** | **11.9783 μs** | **44.358 μs** | **42.645 μs** | **64.195 μs** |   **14336 B** |
| StringFormat       | 100    | 46.620 μs | 393.616 μs | 21.5754 μs | 34.234 μs | 34.093 μs | 71.533 μs |   16736 B |
| InterpolatedFormat | 100    | 37.389 μs | 164.260 μs |  9.0036 μs | 32.851 μs | 31.558 μs | 47.759 μs |   14336 B |
