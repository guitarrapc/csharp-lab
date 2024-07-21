```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.892 μs** |   **2.510 μs** |  **0.1376 μs** |  **5.861 μs** |  **5.772 μs** |  **6.042 μs** |     **872 B** |
| StringFormat       | 1      |  7.438 μs |   2.753 μs |  0.1509 μs |  7.425 μs |  7.294 μs |  7.595 μs |     896 B |
| InterpolatedFormat | 1      |  5.967 μs |   1.011 μs |  0.0554 μs |  5.941 μs |  5.930 μs |  6.031 μs |     872 B |
| **CompositeFormat**    | **100**    | **42.729 μs** | **288.735 μs** | **15.8265 μs** | **33.672 μs** | **33.512 μs** | **61.004 μs** |   **14336 B** |
| StringFormat       | 100    | 45.368 μs |   6.215 μs |  0.3407 μs | 45.355 μs | 45.034 μs | 45.715 μs |   16736 B |
| InterpolatedFormat | 100    | 35.099 μs | 121.062 μs |  6.6358 μs | 31.378 μs | 31.159 μs | 42.761 μs |   14336 B |
