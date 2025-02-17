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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.875 μs** |   **6.594 μs** |  **0.3614 μs** |  **5.524 μs** |  **6.247 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.019 μs |   2.352 μs |  0.1289 μs |  6.872 μs |  7.114 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  7.399 μs |  10.889 μs |  0.5969 μs |  6.718 μs |  7.830 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.758 μs |   3.109 μs |  0.1704 μs |  5.581 μs |  5.921 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.834 μs |   3.956 μs |  0.2169 μs |  5.680 μs |  6.082 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.391 μs |   4.664 μs |  0.2556 μs |  5.140 μs |  5.651 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **37.232 μs** | **144.402 μs** |  **7.9151 μs** | **32.380 μs** | **46.366 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.818 μs | 167.524 μs |  9.1826 μs | 34.014 μs | 50.405 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 35.672 μs | 132.648 μs |  7.2709 μs | 31.123 μs | 44.057 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 42.389 μs | 225.577 μs | 12.3647 μs | 35.195 μs | 56.666 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.594 μs | 170.918 μs |  9.3686 μs | 27.090 μs | 43.411 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.191 μs | 155.558 μs |  8.5267 μs | 23.814 μs | 39.023 μs |   14336 B |
