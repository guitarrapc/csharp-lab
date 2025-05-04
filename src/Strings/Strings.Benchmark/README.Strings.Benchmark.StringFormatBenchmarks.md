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
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.423 μs** |   **7.0955 μs** |  **0.3889 μs** |  **6.306 μs** |  **6.106 μs** |  **6.857 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.204 μs |   3.8442 μs |  0.2107 μs |  7.224 μs |  6.984 μs |  7.404 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.144 μs |   2.5693 μs |  0.1408 μs |  6.100 μs |  6.031 μs |  6.302 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.503 μs |   0.5267 μs |  0.0289 μs |  5.520 μs |  5.470 μs |  5.520 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.527 μs |   2.3281 μs |  0.1276 μs |  5.551 μs |  5.389 μs |  5.641 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.764 μs |  10.1817 μs |  0.5581 μs |  5.981 μs |  5.130 μs |  6.181 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **44.961 μs** | **365.5895 μs** | **20.0392 μs** | **33.673 μs** | **33.112 μs** | **68.098 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.073 μs | 155.1027 μs |  8.5017 μs | 34.524 μs | 33.813 μs | 48.881 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 37.794 μs | 175.6578 μs |  9.6284 μs | 32.300 μs | 32.171 μs | 48.912 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 43.117 μs | 233.9417 μs | 12.8231 μs | 36.067 μs | 35.365 μs | 57.918 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 33.970 μs | 210.1646 μs | 11.5198 μs | 27.602 μs | 27.040 μs | 47.268 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.335 μs | 159.5651 μs |  8.7463 μs | 24.305 μs | 24.265 μs | 39.434 μs |   14336 B |
