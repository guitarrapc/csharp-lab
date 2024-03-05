```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error        | StdDev     | Median    | Min       | Max        | Allocated |
|------------------- |------- |----------:|-------------:|-----------:|----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.749 μs** |     **9.370 μs** |  **0.5136 μs** |  **6.923 μs** |  **6.171 μs** |   **7.153 μs** |     **872 B** |
| StringFormat       | 1      |  6.181 μs |     5.938 μs |  0.3255 μs |  6.091 μs |  5.910 μs |   6.542 μs |     896 B |
| InterpolatedFormat | 1      |  6.451 μs |     9.586 μs |  0.5255 μs |  6.682 μs |  5.850 μs |   6.822 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.597 μs** |    **31.910 μs** |  **1.7491 μs** | **44.112 μs** | **43.142 μs** |  **46.538 μs** |   **14336 B** |
| StringFormat       | 100    | 41.775 μs |   170.704 μs |  9.3568 μs | 36.448 μs | 36.298 μs |  52.579 μs |   16736 B |
| InterpolatedFormat | 100    | 75.886 μs | 1,150.786 μs | 63.0784 μs | 49.223 μs | 30.518 μs | 147.918 μs |   14336 B |
