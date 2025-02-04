```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.212 μs** |   **0.7471 μs** |  **0.0410 μs** |  **5.175 μs** |  **5.255 μs** |     **584 B** |
| StringFormat       | 1      |  6.187 μs |   1.7866 μs |  0.0979 μs |  6.077 μs |  6.266 μs |     896 B |
| InterpolatedFormat | 1      |  5.424 μs |   6.6320 μs |  0.3635 μs |  5.010 μs |  5.691 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.545 μs** | **202.5777 μs** | **11.1040 μs** | **36.969 μs** | **56.365 μs** |   **14336 B** |
| StringFormat       | 100    | 44.006 μs | 147.7372 μs |  8.0980 μs | 38.272 μs | 53.270 μs |   16736 B |
| InterpolatedFormat | 100    | 29.682 μs | 156.0633 μs |  8.5544 μs | 24.455 μs | 39.554 μs |   14336 B |
