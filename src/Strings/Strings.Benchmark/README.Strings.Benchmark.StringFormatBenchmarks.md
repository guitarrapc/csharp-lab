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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      | **10.235 μs** |   **4.433 μs** |  **0.2430 μs** | **10.104 μs** | **10.085 μs** | **10.515 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.598 μs |  13.655 μs |  0.7485 μs |  7.253 μs |  7.083 μs |  8.457 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.323 μs |   2.114 μs |  0.1159 μs |  6.266 μs |  6.247 μs |  6.457 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  7.169 μs |   9.609 μs |  0.5267 μs |  7.022 μs |  6.732 μs |  7.754 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  6.232 μs |   8.199 μs |  0.4494 μs |  6.332 μs |  5.741 μs |  6.623 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.825 μs |   2.659 μs |  0.1458 μs |  5.815 μs |  5.685 μs |  5.976 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **44.129 μs** |  **45.007 μs** |  **2.4670 μs** | **42.739 μs** | **42.670 μs** | **46.977 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 40.994 μs | 198.033 μs | 10.8549 μs | 35.096 μs | 34.365 μs | 53.521 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 50.000 μs | 252.729 μs | 13.8529 μs | 42.739 μs | 41.287 μs | 65.974 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 35.263 μs | 297.016 μs | 16.2805 μs | 25.909 μs | 25.818 μs | 54.062 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.200 μs | 153.490 μs |  8.4133 μs | 27.841 μs | 26.860 μs | 41.898 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.410 μs | 147.292 μs |  8.0736 μs | 23.925 μs | 23.574 μs | 37.730 μs |   14048 B |
