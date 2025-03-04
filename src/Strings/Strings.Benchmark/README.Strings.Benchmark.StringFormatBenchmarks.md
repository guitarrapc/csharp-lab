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
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.072 μs** |   **8.4546 μs** |  **0.4634 μs** |  **5.861 μs** |  **5.751 μs** |  **6.603 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.629 μs |   3.5799 μs |  0.1962 μs |  6.683 μs |  6.411 μs |  6.792 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.762 μs |  11.6995 μs |  0.6413 μs |  6.853 μs |  6.080 μs |  7.354 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.222 μs |   7.1305 μs |  0.3908 μs |  6.121 μs |  5.891 μs |  6.653 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.533 μs |   0.1110 μs |  0.0061 μs |  5.530 μs |  5.529 μs |  5.540 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.009 μs |   2.2418 μs |  0.1229 μs |  5.059 μs |  4.869 μs |  5.099 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **47.676 μs** | **189.4147 μs** | **10.3825 μs** | **41.939 μs** | **41.428 μs** | **59.661 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 42.056 μs | 212.5247 μs | 11.6492 μs | 35.331 μs | 35.331 μs | 55.508 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 47.936 μs | 188.6580 μs | 10.3410 μs | 42.279 μs | 41.657 μs | 59.871 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 31.808 μs | 183.5191 μs | 10.0593 μs | 26.364 μs | 25.642 μs | 43.416 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 39.386 μs | 366.0261 μs | 20.0631 μs | 28.953 μs | 26.689 μs | 62.516 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 36.248 μs |  91.8418 μs |  5.0342 μs | 33.483 μs | 33.202 μs | 42.059 μs |   14336 B |
