```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.178 μs** |   **6.427 μs** | **0.3523 μs** |  **5.870 μs** |  **6.562 μs** |     **872 B** |
| StringFormat       | 1      |  6.141 μs |   3.175 μs | 0.1740 μs |  5.991 μs |  6.332 μs |     896 B |
| InterpolatedFormat | 1      |  6.051 μs |   8.261 μs | 0.4528 μs |  5.671 μs |  6.552 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.984 μs** | **131.296 μs** | **7.1968 μs** | **32.596 μs** | **45.290 μs** |   **14336 B** |
| StringFormat       | 100    | 45.639 μs |  24.316 μs | 1.3328 μs | 44.864 μs | 47.178 μs |   16736 B |
| InterpolatedFormat | 100    | 38.752 μs | 148.436 μs | 8.1363 μs | 31.629 μs | 47.619 μs |   14336 B |
