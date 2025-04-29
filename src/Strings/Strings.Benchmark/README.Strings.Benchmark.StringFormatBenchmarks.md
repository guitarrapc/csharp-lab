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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.032 μs** |   **1.5852 μs** |  **0.0869 μs** |  **5.982 μs** |  **5.981 μs** |  **6.132 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.279 μs |   0.2887 μs |  0.0158 μs |  6.282 μs |  6.261 μs |  6.293 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.630 μs |   1.8104 μs |  0.0992 μs |  6.678 μs |  6.516 μs |  6.697 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.015 μs |   2.6895 μs |  0.1474 μs |  5.962 μs |  5.902 μs |  6.182 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.527 μs |   0.2787 μs |  0.0153 μs |  5.530 μs |  5.510 μs |  5.540 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.012 μs |   0.7373 μs |  0.0404 μs |  4.989 μs |  4.989 μs |  5.059 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **40.203 μs** | **229.4328 μs** | **12.5760 μs** | **33.002 μs** | **32.882 μs** | **54.724 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.587 μs | 129.2836 μs |  7.0865 μs | 34.971 μs | 34.038 μs | 46.752 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 48.100 μs | 196.3037 μs | 10.7601 μs | 42.890 μs | 40.936 μs | 60.473 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 36.637 μs | 319.2466 μs | 17.4990 μs | 26.765 μs | 26.305 μs | 56.842 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.716 μs | 146.1729 μs |  8.0122 μs | 27.192 μs | 26.991 μs | 40.968 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.894 μs | 159.9460 μs |  8.7672 μs | 24.095 μs | 23.574 μs | 39.013 μs |   14336 B |
