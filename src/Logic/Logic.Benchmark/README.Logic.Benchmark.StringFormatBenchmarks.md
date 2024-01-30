```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.690 μs** |   **8.898 μs** |  **0.4877 μs** |  **6.162 μs** |  **7.124 μs** |     **872 B** |
| StringFormat       | 1      |  7.204 μs |   9.140 μs |  0.5010 μs |  6.702 μs |  7.705 μs |     896 B |
| InterpolatedFormat | 1      |  6.772 μs |   3.671 μs |  0.2012 μs |  6.562 μs |  6.963 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.277 μs** | **223.784 μs** | **12.2663 μs** | **43.080 μs** | **64.440 μs** |   **14336 B** |
| StringFormat       | 100    | 37.811 μs | 132.486 μs |  7.2620 μs | 33.583 μs | 46.196 μs |   16736 B |
| InterpolatedFormat | 100    | 48.464 μs | 227.566 μs | 12.4737 μs | 41.247 μs | 62.867 μs |   14336 B |
