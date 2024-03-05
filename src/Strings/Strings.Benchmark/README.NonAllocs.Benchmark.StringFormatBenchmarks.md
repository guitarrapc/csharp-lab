```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.084 μs** |   **1.417 μs** |  **0.0777 μs** |  **6.061 μs** |  **6.021 μs** |  **6.171 μs** |     **872 B** |
| StringFormat       | 1      |  7.427 μs |   3.725 μs |  0.2042 μs |  7.474 μs |  7.203 μs |  7.603 μs |     896 B |
| InterpolatedFormat | 1      |  6.118 μs |   8.978 μs |  0.4921 μs |  5.891 μs |  5.781 μs |  6.683 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.532 μs** | **129.841 μs** |  **7.1170 μs** | **32.691 μs** | **32.160 μs** | **44.744 μs** |   **14336 B** |
| StringFormat       | 100    | 37.611 μs | 129.490 μs |  7.0978 μs | 33.553 μs | 33.474 μs | 45.806 μs |   16736 B |
| InterpolatedFormat | 100    | 41.602 μs | 306.564 μs | 16.8038 μs | 31.940 μs | 31.860 μs | 61.005 μs |   14336 B |
