```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.789 μs** |   **0.5969 μs** |  **0.0327 μs** |  **5.766 μs** |  **5.827 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.017 μs |   3.0065 μs |  0.1648 μs |  6.893 μs |  7.204 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.764 μs |   2.0201 μs |  0.1107 μs |  5.690 μs |  5.891 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.534 μs |   1.5463 μs |  0.0848 μs |  5.479 μs |  5.631 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.350 μs |   2.1610 μs |  0.1184 μs |  5.250 μs |  5.481 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.110 μs |   1.2836 μs |  0.0704 μs |  5.059 μs |  5.190 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **48.534 μs** | **205.9829 μs** | **11.2906 μs** | **41.668 μs** | **61.565 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 44.991 μs | 162.7726 μs |  8.9221 μs | 34.716 μs | 50.775 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 47.611 μs | 186.1001 μs | 10.2008 μs | 41.667 μs | 59.390 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 41.100 μs |  80.0551 μs |  4.3881 μs | 38.522 μs | 46.167 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.375 μs | 148.7433 μs |  8.1531 μs | 26.440 μs | 40.786 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 38.772 μs |  10.2307 μs |  0.5608 μs | 38.201 μs | 39.322 μs |   14336 B |
