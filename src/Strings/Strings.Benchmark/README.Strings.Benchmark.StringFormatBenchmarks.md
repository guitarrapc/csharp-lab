```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.303 μs** |   **0.9086 μs** |  **0.0498 μs** |  **5.309 μs** |  **5.250 μs** |  **5.349 μs** |     **584 B** |
| StringFormat       | 1      |  5.791 μs |   7.2962 μs |  0.3999 μs |  5.570 μs |  5.551 μs |  6.253 μs |     896 B |
| InterpolatedFormat | 1      |  5.116 μs |   1.8462 μs |  0.1012 μs |  5.130 μs |  5.009 μs |  5.210 μs |     584 B |
| **CompositeFormat**    | **100**    | **48.273 μs** | **150.3423 μs** |  **8.2408 μs** | **43.651 μs** | **43.380 μs** | **57.787 μs** |   **14336 B** |
| StringFormat       | 100    | 42.426 μs | 431.1132 μs | 23.6308 μs | 29.745 μs | 27.842 μs | 69.690 μs |   16736 B |
| InterpolatedFormat | 100    | 30.459 μs | 167.5729 μs |  9.1852 μs | 25.383 μs | 24.931 μs | 41.062 μs |   14336 B |
