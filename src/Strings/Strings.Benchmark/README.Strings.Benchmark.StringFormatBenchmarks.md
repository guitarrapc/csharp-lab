```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.132 μs** |   **2.396 μs** | **0.1313 μs** |  **5.981 μs** |  **6.222 μs** |     **872 B** |
| StringFormat       | 1      |  6.903 μs |   9.782 μs | 0.5362 μs |  6.292 μs |  7.294 μs |     896 B |
| InterpolatedFormat | 1      |  6.582 μs |   4.134 μs | 0.2266 μs |  6.331 μs |  6.772 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.628 μs** | **161.920 μs** | **8.8754 μs** | **31.128 μs** | **46.867 μs** |   **14336 B** |
| StringFormat       | 100    | 38.688 μs | 120.630 μs | 6.6121 μs | 34.434 μs | 46.306 μs |   16736 B |
| InterpolatedFormat | 100    | 35.039 μs | 126.745 μs | 6.9473 μs | 30.958 μs | 43.061 μs |   14336 B |
