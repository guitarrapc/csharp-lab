```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **7.354 μs** |  **16.880 μs** |  **0.9252 μs** |  **7.505 μs** |  **6.363 μs** |  **8.195 μs** |     **872 B** |
| StringFormat       | 1      |  6.035 μs |   3.429 μs |  0.1880 μs |  5.931 μs |  5.922 μs |  6.252 μs |     896 B |
| InterpolatedFormat | 1      |  5.657 μs |   2.114 μs |  0.1159 μs |  5.640 μs |  5.550 μs |  5.780 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.426 μs** | **235.283 μs** | **12.8966 μs** | **33.026 μs** | **32.935 μs** | **55.318 μs** |   **14336 B** |
| StringFormat       | 100    | 37.964 μs | 142.567 μs |  7.8146 μs | 33.502 μs | 33.402 μs | 46.987 μs |   16736 B |
| InterpolatedFormat | 100    | 42.041 μs | 328.573 μs | 18.0102 μs | 31.849 μs | 31.439 μs | 62.837 μs |   14336 B |
