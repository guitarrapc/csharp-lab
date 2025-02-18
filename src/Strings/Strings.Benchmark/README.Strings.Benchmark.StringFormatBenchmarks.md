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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.239 μs** |   **0.8374 μs** |  **0.0459 μs** |  **6.212 μs** |  **6.292 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.686 μs |   2.1766 μs |  0.1193 μs |  6.613 μs |  6.824 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.741 μs |   5.9660 μs |  0.3270 μs |  6.397 μs |  7.048 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.275 μs |   4.6986 μs |  0.2575 μs |  6.121 μs |  6.572 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  6.306 μs |   5.1520 μs |  0.2824 μs |  6.082 μs |  6.623 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.651 μs |   0.3650 μs |  0.0200 μs |  5.631 μs |  5.671 μs |     200 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **36.720 μs** | **146.0561 μs** |  **8.0058 μs** | **31.864 μs** | **45.961 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.443 μs | 140.0971 μs |  7.6792 μs | 34.904 μs | 48.309 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.431 μs | 136.2199 μs |  7.4667 μs | 31.518 μs | 45.023 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 47.948 μs | 178.7097 μs |  9.7957 μs | 42.053 μs | 59.255 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 33.981 μs | 214.4296 μs | 11.7536 μs | 26.213 μs | 47.504 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.341 μs | 183.8349 μs | 10.0766 μs | 23.433 μs | 40.977 μs |   14048 B |
