```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.172 μs** |   **3.976 μs** | **0.2179 μs** |  **6.022 μs** |  **6.422 μs** |     **872 B** |
| StringFormat       | 1      |  6.301 μs |   4.595 μs | 0.2519 μs |  6.011 μs |  6.461 μs |     896 B |
| InterpolatedFormat | 1      |  5.948 μs |   3.349 μs | 0.1836 μs |  5.741 μs |  6.091 μs |     872 B |
| **CompositeFormat**    | **100**    | **66.481 μs** | **166.931 μs** | **9.1500 μs** | **60.313 μs** | **76.994 μs** |   **14336 B** |
| StringFormat       | 100    | 36.614 μs | 131.427 μs | 7.2040 μs | 32.419 μs | 44.932 μs |   16736 B |
| InterpolatedFormat | 100    | 60.950 μs | 124.204 μs | 6.8080 μs | 56.816 μs | 68.808 μs |   14336 B |
