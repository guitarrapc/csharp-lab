```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.438 μs** |  **10.326 μs** |  **0.5660 μs** |  **5.871 μs** |  **7.003 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.986 μs |   5.145 μs |  0.2820 μs |  6.723 μs |  7.284 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.146 μs |  18.544 μs |  1.0165 μs |  5.524 μs |  7.319 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.910 μs |   2.854 μs |  0.1565 μs |  5.730 μs |  6.010 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.918 μs |   6.944 μs |  0.3806 μs |  5.641 μs |  6.352 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.093 μs |   3.752 μs |  0.2057 μs |  4.918 μs |  5.319 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **48.850 μs** | **198.065 μs** | **10.8566 μs** | **42.368 μs** | **61.384 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.250 μs | 151.879 μs |  8.3250 μs | 34.294 μs | 48.861 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 48.334 μs | 197.295 μs | 10.8144 μs | 41.388 μs | 60.794 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 43.465 μs | 263.731 μs | 14.4560 μs | 34.756 μs | 60.152 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.371 μs | 161.053 μs |  8.8279 μs | 26.184 μs | 41.564 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 35.813 μs |  84.461 μs |  4.6296 μs | 33.001 μs | 41.156 μs |   14336 B |
