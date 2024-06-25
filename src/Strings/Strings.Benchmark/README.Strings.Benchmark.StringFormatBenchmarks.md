```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.102 μs** |   **0.3649 μs** |  **0.0200 μs** |  **6.082 μs** |  **6.122 μs** |     **872 B** |
| StringFormat       | 1      |  7.290 μs |   0.8725 μs |  0.0478 μs |  7.253 μs |  7.344 μs |     896 B |
| InterpolatedFormat | 1      |  6.122 μs |   3.8325 μs |  0.2101 μs |  5.942 μs |  6.353 μs |     872 B |
| **CompositeFormat**    | **100**    | **45.791 μs** | **263.1028 μs** | **14.4215 μs** | **32.322 μs** | **61.006 μs** |   **14336 B** |
| StringFormat       | 100    | 52.670 μs | 215.1429 μs | 11.7927 μs | 45.716 μs | 66.286 μs |   16736 B |
| InterpolatedFormat | 100    | 34.955 μs | 125.6543 μs |  6.8875 μs | 30.667 μs | 42.900 μs |   14336 B |
