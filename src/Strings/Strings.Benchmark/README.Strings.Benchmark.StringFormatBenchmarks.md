```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.135 μs** |   **2.114 μs** |  **0.1159 μs** |  **6.012 μs** |  **6.242 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.767 μs |  17.468 μs |  0.9575 μs |  6.962 μs |  8.826 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.077 μs |   2.841 μs |  0.1557 μs |  5.931 μs |  6.241 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.480 μs |   5.165 μs |  0.2831 μs |  6.282 μs |  6.804 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.764 μs |   8.703 μs |  0.4770 μs |  5.390 μs |  6.301 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.013 μs |   1.369 μs |  0.0751 μs |  4.970 μs |  5.100 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **35.592 μs** | **134.446 μs** |  **7.3694 μs** | **31.257 μs** | **44.101 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 45.395 μs | 191.714 μs | 10.5085 μs | 34.244 μs | 55.114 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 54.668 μs | 204.259 μs | 11.1961 μs | 41.757 μs | 61.695 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 44.107 μs | 229.257 μs | 12.5663 μs | 36.583 μs | 58.614 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.391 μs | 137.720 μs |  7.5489 μs | 28.003 μs | 41.108 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.411 μs | 144.964 μs |  7.9460 μs | 24.255 μs | 38.562 μs |   14336 B |
