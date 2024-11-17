```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.327 μs** |   **4.1281 μs** |  **0.2263 μs** |  **6.207 μs** |  **6.186 μs** |  **6.588 μs** |     **872 B** |
| StringFormat       | 1      |  6.350 μs |   1.6352 μs |  0.0896 μs |  6.396 μs |  6.247 μs |  6.407 μs |     896 B |
| InterpolatedFormat | 1      |  6.014 μs |   0.8895 μs |  0.0488 μs |  5.991 μs |  5.981 μs |  6.070 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.663 μs** | **348.2376 μs** | **19.0881 μs** | **33.662 μs** | **33.623 μs** | **66.704 μs** |   **14336 B** |
| StringFormat       | 100    | 37.582 μs | 145.0660 μs |  7.9516 μs | 33.127 μs | 32.856 μs | 46.763 μs |   16736 B |
| InterpolatedFormat | 100    | 56.422 μs | 594.5223 μs | 32.5878 μs | 43.681 μs | 32.129 μs | 93.455 μs |   14336 B |
