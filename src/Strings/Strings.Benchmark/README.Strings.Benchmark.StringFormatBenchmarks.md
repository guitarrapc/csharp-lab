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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.054 μs** |   **0.5574 μs** |  **0.0306 μs** |  **6.061 μs** |  **6.021 μs** |  **6.081 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.331 μs |   1.2418 μs |  0.0681 μs |  7.354 μs |  7.254 μs |  7.384 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.091 μs |   8.3901 μs |  0.4599 μs |  5.832 μs |  5.821 μs |  6.622 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.519 μs |  22.9401 μs |  1.2574 μs |  6.231 μs |  5.431 μs |  7.896 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.867 μs |  14.8750 μs |  0.8153 μs |  5.490 μs |  5.309 μs |  6.803 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.697 μs |   9.0471 μs |  0.4959 μs |  5.720 μs |  5.190 μs |  6.181 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **37.394 μs** | **135.4531 μs** |  **7.4246 μs** | **33.163 μs** | **33.052 μs** | **45.967 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.782 μs | 146.6930 μs |  8.0407 μs | 34.644 μs | 33.653 μs | 48.049 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 51.255 μs | 206.2070 μs | 11.3029 μs | 49.271 μs | 41.076 μs | 63.419 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 36.754 μs | 319.7489 μs | 17.5265 μs | 26.715 μs | 26.555 μs | 56.992 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.089 μs | 172.8621 μs |  9.4752 μs | 26.689 μs | 26.549 μs | 43.030 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 38.211 μs | 107.8785 μs |  5.9132 μs | 35.576 μs | 34.074 μs | 44.984 μs |   14336 B |
