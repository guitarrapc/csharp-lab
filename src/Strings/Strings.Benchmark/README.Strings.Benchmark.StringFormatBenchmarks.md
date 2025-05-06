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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.090 μs** |   **1.0987 μs** |  **0.0602 μs** |  **6.096 μs** |  **6.027 μs** |  **6.146 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.138 μs |   5.0591 μs |  0.2773 μs |  7.288 μs |  6.819 μs |  7.309 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.446 μs |   6.9749 μs |  0.3823 μs |  6.363 μs |  6.112 μs |  6.863 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.002 μs |   0.8360 μs |  0.0458 μs |  6.012 μs |  5.952 μs |  6.042 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.603 μs |   0.2107 μs |  0.0115 μs |  5.610 μs |  5.590 μs |  5.610 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  7.814 μs |  71.3079 μs |  3.9086 μs |  5.980 μs |  5.159 μs | 12.302 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **81.997 μs** |  **48.4447 μs** |  **2.6554 μs** | **81.403 μs** | **79.689 μs** | **84.900 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.642 μs | 131.2845 μs |  7.1961 μs | 34.714 μs | 34.264 μs | 46.947 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 50.819 μs | 269.3237 μs | 14.7625 μs | 42.761 μs | 41.839 μs | 67.857 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 34.185 μs | 227.2985 μs | 12.4590 μs | 27.576 μs | 26.423 μs | 48.556 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 44.800 μs | 213.4973 μs | 11.7025 μs | 38.581 μs | 37.520 μs | 58.299 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.742 μs | 176.0711 μs |  9.6511 μs | 24.206 μs | 24.136 μs | 40.886 μs |   14336 B |
