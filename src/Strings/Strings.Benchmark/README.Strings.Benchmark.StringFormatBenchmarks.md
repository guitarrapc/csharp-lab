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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.733 μs** |   **4.135 μs** |  **0.2266 μs** |  **6.583 μs** |  **6.994 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.926 μs |   9.870 μs |  0.5410 μs |  6.372 μs |  7.453 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.662 μs |   5.195 μs |  0.2848 μs |  6.412 μs |  6.973 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.313 μs |  13.683 μs |  0.7500 μs |  4.639 μs |  6.121 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.698 μs |   1.483 μs |  0.0813 μs |  5.611 μs |  5.772 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.690 μs |   4.241 μs |  0.2325 μs |  4.513 μs |  4.954 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **38.435 μs** | **192.098 μs** | **10.5295 μs** | **32.310 μs** | **50.593 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.453 μs | 129.404 μs |  7.0931 μs | 34.228 μs | 46.642 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 45.314 μs |  29.774 μs |  1.6320 μs | 43.471 μs | 46.576 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 32.241 μs | 181.732 μs |  9.9613 μs | 26.410 μs | 43.743 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.485 μs | 158.827 μs |  8.7059 μs | 26.450 μs | 41.538 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.710 μs | 151.863 μs |  8.3241 μs | 23.814 μs | 38.321 μs |   14336 B |
