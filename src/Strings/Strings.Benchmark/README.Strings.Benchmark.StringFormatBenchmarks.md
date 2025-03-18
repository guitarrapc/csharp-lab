```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **7.023 μs** |   **3.0149 μs** |  **0.1653 μs** |  **7.034 μs** |  **6.853 μs** |  **7.183 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.594 μs |   3.3247 μs |  0.1822 μs |  7.494 μs |  7.483 μs |  7.804 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.890 μs |   1.4144 μs |  0.0775 μs |  5.930 μs |  5.801 μs |  5.940 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.781 μs |   4.0855 μs |  0.2239 μs |  5.710 μs |  5.601 μs |  6.032 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  6.494 μs |   5.1131 μs |  0.2803 μs |  6.598 μs |  6.176 μs |  6.707 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.196 μs |   0.8622 μs |  0.0473 μs |  5.179 μs |  5.159 μs |  5.249 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **64.030 μs** | **131.3463 μs** |  **7.1995 μs** | **63.690 μs** | **57.007 μs** | **71.394 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 47.321 μs | 392.7014 μs | 21.5253 μs | 35.185 μs | 34.604 μs | 72.174 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 48.855 μs | 188.8601 μs | 10.3521 μs | 43.402 μs | 42.370 μs | 60.794 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 43.675 μs | 256.2408 μs | 14.0454 μs | 35.716 μs | 35.416 μs | 59.892 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 33.155 μs | 180.3996 μs |  9.8883 μs | 27.471 μs | 27.421 μs | 44.573 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 33.936 μs | 153.1664 μs |  8.3956 μs | 38.572 μs | 24.245 μs | 38.992 μs |   14336 B |
