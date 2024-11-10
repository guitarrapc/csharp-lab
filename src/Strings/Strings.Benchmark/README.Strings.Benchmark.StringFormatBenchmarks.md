```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.704 μs** |   **1.685 μs** |  **0.0924 μs** |  **6.758 μs** |  **6.598 μs** |  **6.758 μs** |     **872 B** |
| StringFormat       | 1      |  6.118 μs |   5.865 μs |  0.3215 μs |  6.251 μs |  5.751 μs |  6.351 μs |     896 B |
| InterpolatedFormat | 1      |  5.801 μs |   1.894 μs |  0.1038 μs |  5.851 μs |  5.681 μs |  5.870 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.694 μs** | **371.245 μs** | **20.3492 μs** | **33.282 μs** | **32.611 μs** | **68.188 μs** |   **14336 B** |
| StringFormat       | 100    | 50.197 μs | 314.864 μs | 17.2587 μs | 47.829 μs | 34.244 μs | 68.517 μs |   16736 B |
| InterpolatedFormat | 100    | 37.173 μs | 131.974 μs |  7.2339 μs | 33.062 μs | 32.931 μs | 45.526 μs |   14336 B |
