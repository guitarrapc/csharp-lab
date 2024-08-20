```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.165 μs** |   **2.3829 μs** | **0.1306 μs** |  **6.032 μs** |  **6.293 μs** |     **872 B** |
| StringFormat       | 1      |  6.498 μs |   2.3031 μs | 0.1262 μs |  6.402 μs |  6.641 μs |     896 B |
| InterpolatedFormat | 1      |  5.840 μs |   0.4793 μs | 0.0263 μs |  5.820 μs |  5.870 μs |     872 B |
| **CompositeFormat**    | **100**    | **65.507 μs** | **141.7810 μs** | **7.7715 μs** | **60.945 μs** | **74.480 μs** |   **14336 B** |
| StringFormat       | 100    | 37.750 μs | 136.9353 μs | 7.5059 μs | 33.391 μs | 46.417 μs |   16736 B |
| InterpolatedFormat | 100    | 35.149 μs | 128.4926 μs | 7.0431 μs | 31.017 μs | 43.281 μs |   14336 B |
