```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.417 μs** |   **1.840 μs** |  **0.1008 μs** |  **5.471 μs** |  **5.301 μs** |  **5.480 μs** |     **872 B** |
| StringFormat       | 1      |  6.465 μs |   2.108 μs |  0.1155 μs |  6.463 μs |  6.351 μs |  6.582 μs |     896 B |
| InterpolatedFormat | 1      |  5.396 μs |   1.304 μs |  0.0715 μs |  5.410 μs |  5.319 μs |  5.460 μs |     584 B |
| **CompositeFormat**    | **100**    | **33.886 μs** | **260.666 μs** | **14.2880 μs** | **26.148 μs** | **25.136 μs** | **50.374 μs** |   **14336 B** |
| StringFormat       | 100    | 35.432 μs | 183.671 μs | 10.0676 μs | 29.705 μs | 29.535 μs | 47.057 μs |   16448 B |
| InterpolatedFormat | 100    | 30.102 μs | 188.262 μs | 10.3193 μs | 24.145 μs | 24.144 μs | 42.018 μs |   14048 B |
