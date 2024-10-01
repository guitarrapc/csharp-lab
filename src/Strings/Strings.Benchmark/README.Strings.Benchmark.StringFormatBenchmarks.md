```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.195 μs** |   **1.369 μs** |  **0.0751 μs** |  **6.152 μs** |  **6.282 μs** |     **872 B** |
| StringFormat       | 1      |  7.154 μs |   4.858 μs |  0.2663 μs |  6.904 μs |  7.434 μs |     896 B |
| InterpolatedFormat | 1      |  5.728 μs |   3.723 μs |  0.2041 μs |  5.581 μs |  5.961 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.024 μs** | **194.914 μs** | **10.6839 μs** | **42.825 μs** | **61.361 μs** |   **14336 B** |
| StringFormat       | 100    | 37.951 μs | 126.165 μs |  6.9155 μs | 33.894 μs | 45.936 μs |   16736 B |
| InterpolatedFormat | 100    | 35.493 μs | 129.395 μs |  7.0926 μs | 31.298 μs | 43.682 μs |   14336 B |
