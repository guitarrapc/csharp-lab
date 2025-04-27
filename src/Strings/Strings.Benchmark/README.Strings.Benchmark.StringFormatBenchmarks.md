```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.988 μs** |   **3.398 μs** |  **0.1862 μs** |  **6.041 μs** |  **5.781 μs** |  **6.142 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.035 μs |   4.867 μs |  0.2668 μs |  7.059 μs |  6.758 μs |  7.290 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.482 μs |  11.518 μs |  0.6314 μs |  6.572 μs |  5.810 μs |  7.063 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.088 μs |   4.970 μs |  0.2724 μs |  6.182 μs |  5.781 μs |  6.301 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.502 μs |   1.734 μs |  0.0950 μs |  5.505 μs |  5.405 μs |  5.596 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.102 μs |   1.906 μs |  0.1045 μs |  5.069 μs |  5.018 μs |  5.219 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **59.083 μs** | **179.991 μs** |  **9.8659 μs** | **55.510 μs** | **51.502 μs** | **70.237 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.965 μs | 150.038 μs |  8.2241 μs | 35.978 μs | 34.495 μs | 49.423 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.796 μs | 150.293 μs |  8.2381 μs | 32.170 μs | 31.910 μs | 46.307 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 42.406 μs | 227.178 μs | 12.4524 μs | 35.647 μs | 34.794 μs | 56.776 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 41.882 μs | 119.222 μs |  6.5349 μs | 38.532 μs | 37.702 μs | 49.413 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 38.168 μs | 434.421 μs | 23.8121 μs | 24.565 μs | 24.275 μs | 65.663 μs |   14048 B |
