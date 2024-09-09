```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **7.334 μs** |  **15.907 μs** |  **0.8719 μs** |  **6.593 μs** |  **8.295 μs** |     **872 B** |
| StringFormat       | 1      |  6.813 μs |   6.058 μs |  0.3321 μs |  6.442 μs |  7.083 μs |     896 B |
| InterpolatedFormat | 1      |  6.273 μs |   6.482 μs |  0.3553 μs |  5.976 μs |  6.667 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.054 μs** | **225.198 μs** | **12.3439 μs** | **32.877 μs** | **54.307 μs** |   **14336 B** |
| StringFormat       | 100    | 38.336 μs | 148.368 μs |  8.1325 μs | 33.354 μs | 47.721 μs |   16736 B |
| InterpolatedFormat | 100    | 39.818 μs | 201.783 μs | 11.0604 μs | 30.768 μs | 52.147 μs |   14336 B |
