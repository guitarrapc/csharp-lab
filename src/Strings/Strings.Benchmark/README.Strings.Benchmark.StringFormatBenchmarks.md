```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.459 μs** |   **7.154 μs** |  **0.3921 μs** |  **6.161 μs** |  **6.903 μs** |     **872 B** |
| StringFormat       | 1      |  7.033 μs |  11.868 μs |  0.6505 μs |  6.311 μs |  7.574 μs |     896 B |
| InterpolatedFormat | 1      |  5.783 μs |   2.356 μs |  0.1292 μs |  5.636 μs |  5.877 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.621 μs** | **120.893 μs** |  **6.6266 μs** | **32.397 μs** | **44.258 μs** |   **14336 B** |
| StringFormat       | 100    | 38.224 μs | 168.476 μs |  9.2347 μs | 32.877 μs | 48.888 μs |   16736 B |
| InterpolatedFormat | 100    | 49.405 μs | 252.064 μs | 13.8165 μs | 41.353 μs | 65.359 μs |   14336 B |
