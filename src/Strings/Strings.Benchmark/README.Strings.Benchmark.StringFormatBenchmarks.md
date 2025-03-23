```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.950 μs** |   **6.848 μs** |  **0.3753 μs** |  **6.663 μs** |  **7.375 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.298 μs |   1.734 μs |  0.0950 μs |  6.202 μs |  6.392 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.275 μs |   5.940 μs |  0.3256 μs |  5.921 μs |  6.562 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.247 μs |   2.471 μs |  0.1355 μs |  5.090 μs |  5.330 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.526 μs |   2.018 μs |  0.1106 μs |  5.419 μs |  5.640 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.813 μs |   4.615 μs |  0.2529 μs |  4.603 μs |  5.094 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **55.958 μs** | **225.550 μs** | **12.3632 μs** | **42.099 μs** | **65.853 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 48.758 μs | 302.163 μs | 16.5626 μs | 34.214 μs | 66.785 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 49.969 μs | 258.010 μs | 14.1424 μs | 41.407 μs | 66.293 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 42.112 μs | 215.887 μs | 11.8335 μs | 34.794 μs | 55.764 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 41.121 μs |   6.340 μs |  0.3475 μs | 40.821 μs | 41.502 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 41.156 μs | 227.786 μs | 12.4857 μs | 32.931 μs | 55.523 μs |   14336 B |
