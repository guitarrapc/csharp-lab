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
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.921 μs** |   **2.6931 μs** |  **0.1476 μs** |  **5.841 μs** |  **5.830 μs** |  **6.091 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.152 μs |   0.3466 μs |  0.0190 μs |  6.152 μs |  6.133 μs |  6.171 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.738 μs |  11.4026 μs |  0.6250 μs |  5.561 μs |  5.220 μs |  6.432 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.905 μs |   1.7937 μs |  0.0983 μs |  5.952 μs |  5.792 μs |  5.971 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.670 μs |   1.4354 μs |  0.0787 μs |  5.630 μs |  5.620 μs |  5.761 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.220 μs |   2.7632 μs |  0.1515 μs |  5.240 μs |  5.060 μs |  5.361 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **42.412 μs** | **308.9342 μs** | **16.9337 μs** | **32.741 μs** | **32.530 μs** | **61.965 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 51.139 μs | 198.4652 μs | 10.8785 μs | 45.025 μs | 44.693 μs | 63.699 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 38.212 μs | 194.6142 μs | 10.6675 μs | 32.371 μs | 31.740 μs | 50.524 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 45.250 μs | 282.7292 μs | 15.4973 μs | 37.580 μs | 35.084 μs | 63.087 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 39.786 μs |  17.8408 μs |  0.9779 μs | 39.252 μs | 39.192 μs | 40.915 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 33.750 μs | 212.5576 μs | 11.6510 μs | 31.008 μs | 23.714 μs | 46.527 μs |   14336 B |
