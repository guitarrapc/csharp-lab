```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.932 μs** |   **3.492 μs** |  **0.1914 μs** |  **5.905 μs** |  **5.755 μs** |  **6.135 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.452 μs |   3.353 μs |  0.1838 μs |  7.389 μs |  7.308 μs |  7.659 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.254 μs |   9.309 μs |  0.5103 μs |  6.481 μs |  5.670 μs |  6.612 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.314 μs |   1.076 μs |  0.0590 μs |  5.291 μs |  5.270 μs |  5.381 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.630 μs |   9.483 μs |  0.5198 μs |  5.471 μs |  5.210 μs |  6.212 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.992 μs |  25.035 μs |  1.3723 μs |  5.371 μs |  5.040 μs |  7.565 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **45.200 μs** | **400.055 μs** | **21.9284 μs** | **32.580 μs** | **32.500 μs** | **70.521 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 45.340 μs |  18.640 μs |  1.0217 μs | 44.868 μs | 44.639 μs | 46.513 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 48.648 μs | 241.462 μs | 13.2353 μs | 41.147 μs | 40.867 μs | 63.929 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 37.801 μs | 326.866 μs | 17.9166 μs | 29.165 μs | 25.838 μs | 58.400 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 45.034 μs | 183.182 μs | 10.0408 μs | 41.307 μs | 37.389 μs | 56.405 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.151 μs | 149.954 μs |  8.2195 μs | 24.425 μs | 24.387 μs | 38.642 μs |   14336 B |
