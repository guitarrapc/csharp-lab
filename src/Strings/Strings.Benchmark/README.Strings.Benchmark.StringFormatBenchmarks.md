```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max        | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.469 μs** |  **11.764 μs** |  **0.6448 μs** |  **6.081 μs** |   **7.213 μs** |     **872 B** |
| StringFormat       | 1      |  6.259 μs |   3.600 μs |  0.1973 μs |  6.032 μs |   6.392 μs |     896 B |
| InterpolatedFormat | 1      |  6.095 μs |   4.907 μs |  0.2690 μs |  5.791 μs |   6.302 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.788 μs** | **263.955 μs** | **14.4683 μs** | **44.101 μs** |  **69.490 μs** |   **14336 B** |
| StringFormat       | 100    | 73.304 μs | 811.295 μs | 44.4698 μs | 33.353 μs | 121.217 μs |   16736 B |
| InterpolatedFormat | 100    | 36.486 μs | 156.834 μs |  8.5966 μs | 31.393 μs |  46.411 μs |   14336 B |
