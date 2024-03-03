```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.895 μs** |   **6.6783 μs** | **0.3661 μs** |  **5.604 μs** |  **6.306 μs** |     **872 B** |
| StringFormat       | 1      |  7.129 μs |   2.5723 μs | 0.1410 μs |  6.982 μs |  7.263 μs |     896 B |
| InterpolatedFormat | 1      |  5.721 μs |   0.4827 μs | 0.0265 μs |  5.691 μs |  5.740 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.418 μs** | **125.6082 μs** | **6.8850 μs** | **32.191 μs** | **44.363 μs** |   **14336 B** |
| StringFormat       | 100    | 39.237 μs | 180.3938 μs | 9.8880 μs | 33.523 μs | 50.655 μs |   16736 B |
| InterpolatedFormat | 100    | 35.224 μs | 131.0530 μs | 7.1835 μs | 30.883 μs | 43.516 μs |   14336 B |
