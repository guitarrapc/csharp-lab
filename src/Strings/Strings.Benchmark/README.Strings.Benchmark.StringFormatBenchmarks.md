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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.807 μs** |   **2.121 μs** |  **0.1162 μs** |  **5.751 μs** |  **5.730 μs** |  **5.941 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.210 μs |   4.353 μs |  0.2386 μs |  7.104 μs |  7.043 μs |  7.484 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.924 μs |  11.200 μs |  0.6139 μs |  5.680 μs |  5.469 μs |  6.622 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.152 μs |   1.922 μs |  0.1054 μs |  6.142 μs |  6.052 μs |  6.262 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.781 μs |   7.701 μs |  0.4221 μs |  5.611 μs |  5.471 μs |  6.262 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.697 μs |  16.056 μs |  0.8801 μs |  5.209 μs |  5.169 μs |  6.713 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **50.612 μs** | **239.117 μs** | **13.1068 μs** | **43.145 μs** | **42.945 μs** | **65.746 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.505 μs | 128.245 μs |  7.0296 μs | 34.705 μs | 34.194 μs | 46.617 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.499 μs | 122.529 μs |  6.7162 μs | 32.722 μs | 32.521 μs | 44.253 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 49.021 μs | 440.948 μs | 24.1699 μs | 35.596 μs | 34.544 μs | 76.924 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.295 μs | 147.434 μs |  8.0813 μs | 26.740 μs | 26.520 μs | 40.626 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.826 μs | 137.240 μs |  7.5226 μs | 25.547 μs | 25.418 μs | 38.511 μs |   14048 B |
