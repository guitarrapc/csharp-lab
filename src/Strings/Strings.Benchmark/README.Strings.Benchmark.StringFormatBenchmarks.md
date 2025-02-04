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
| **CompositeFormat**    | **1**      |  **5.374 μs** |   **0.9182 μs** |  **0.0503 μs** |  **5.381 μs** |  **5.321 μs** |  **5.421 μs** |     **872 B** |
| StringFormat       | 1      |  5.690 μs |  12.8256 μs |  0.7030 μs |  5.450 μs |  5.139 μs |  6.482 μs |     896 B |
| InterpolatedFormat | 1      |  6.068 μs |   1.3934 μs |  0.0764 μs |  6.051 μs |  6.001 μs |  6.151 μs |     872 B |
| **CompositeFormat**    | **100**    | **39.596 μs** |   **7.7525 μs** |  **0.4249 μs** | **39.663 μs** | **39.142 μs** | **39.984 μs** |   **14336 B** |
| StringFormat       | 100    | 36.378 μs | 230.9770 μs | 12.6606 μs | 29.255 μs | 28.884 μs | 50.996 μs |   16736 B |
| InterpolatedFormat | 100    | 35.764 μs | 315.4093 μs | 17.2886 μs | 26.060 μs | 25.508 μs | 55.725 μs |   14336 B |
