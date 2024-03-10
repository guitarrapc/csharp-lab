```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.017 μs** |   **3.385 μs** |  **0.1855 μs** |  **5.830 μs** |  **6.201 μs** |     **872 B** |
| StringFormat       | 1      |  6.339 μs |   1.302 μs |  0.0714 μs |  6.262 μs |  6.403 μs |     896 B |
| InterpolatedFormat | 1      |  5.886 μs |   1.105 μs |  0.0606 μs |  5.816 μs |  5.926 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.368 μs** | **211.605 μs** | **11.5988 μs** | **43.482 μs** | **63.759 μs** |   **14336 B** |
| StringFormat       | 100    | 38.683 μs | 142.939 μs |  7.8349 μs | 34.145 μs | 47.730 μs |   16736 B |
| InterpolatedFormat | 100    | 34.594 μs | 132.753 μs |  7.2767 μs | 30.106 μs | 42.990 μs |   14336 B |
