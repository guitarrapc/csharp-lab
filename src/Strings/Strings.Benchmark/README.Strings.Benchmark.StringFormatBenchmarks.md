```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.136 μs** |   **1.5729 μs** |  **0.0862 μs** |  **5.119 μs** |  **5.059 μs** |  **5.229 μs** |     **872 B** |
| StringFormat       | 1      |  6.292 μs |   2.4774 μs |  0.1358 μs |  6.282 μs |  6.162 μs |  6.433 μs |     608 B |
| InterpolatedFormat | 1      |  4.905 μs |   0.6320 μs |  0.0346 μs |  4.885 μs |  4.885 μs |  4.945 μs |     584 B |
| **CompositeFormat**    | **100**    | **43.057 μs** | **217.6155 μs** | **11.9282 μs** | **36.467 μs** | **35.877 μs** | **56.826 μs** |   **14336 B** |
| StringFormat       | 100    | 46.593 μs | 200.4624 μs | 10.9880 μs | 42.705 μs | 38.077 μs | 58.996 μs |   16736 B |
| InterpolatedFormat | 100    | 34.925 μs | 328.6142 μs | 18.0125 μs | 24.625 μs | 24.425 μs | 55.724 μs |   14048 B |
