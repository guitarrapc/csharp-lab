```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.181 μs** |   **7.022 μs** | **0.3849 μs** |  **5.911 μs** |  **6.622 μs** |     **872 B** |
| StringFormat       | 1      |  7.814 μs |  22.131 μs | 1.2131 μs |  6.752 μs |  9.136 μs |     896 B |
| InterpolatedFormat | 1      |  6.519 μs |   1.209 μs | 0.0663 μs |  6.442 μs |  6.561 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.081 μs** | **135.537 μs** | **7.4292 μs** | **33.613 μs** | **46.657 μs** |   **14336 B** |
| StringFormat       | 100    | 51.325 μs |  76.311 μs | 4.1829 μs | 46.553 μs | 54.356 μs |   16736 B |
| InterpolatedFormat | 100    | 36.336 μs | 131.970 μs | 7.2337 μs | 32.084 μs | 44.688 μs |   14336 B |
