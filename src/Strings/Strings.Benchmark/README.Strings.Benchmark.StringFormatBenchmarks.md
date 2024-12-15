```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.311 μs** |   **0.5382 μs** |  **0.0295 μs** |  **5.311 μs** |  **5.281 μs** |  **5.340 μs** |     **872 B** |
| StringFormat       | 1      |  6.065 μs |  11.1642 μs |  0.6119 μs |  6.302 μs |  5.370 μs |  6.523 μs |     896 B |
| InterpolatedFormat | 1      |  5.368 μs |   4.5071 μs |  0.2470 μs |  5.405 μs |  5.105 μs |  5.595 μs |     872 B |
| **CompositeFormat**    | **100**    | **47.291 μs** | **682.0277 μs** | **37.3842 μs** | **26.145 μs** | **25.273 μs** | **90.456 μs** |   **14336 B** |
| StringFormat       | 100    | 45.171 μs | 248.1218 μs | 13.6004 μs | 37.500 μs | 37.139 μs | 60.874 μs |   16736 B |
| InterpolatedFormat | 100    | 31.089 μs | 225.7353 μs | 12.3733 μs | 24.046 μs | 23.845 μs | 45.376 μs |   14336 B |
