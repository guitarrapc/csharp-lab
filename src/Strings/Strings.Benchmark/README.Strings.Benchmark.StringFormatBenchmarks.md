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
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.048 μs** |   **5.0208 μs** |  **0.2752 μs** |  **5.740 μs** |  **6.271 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.987 μs |   4.4880 μs |  0.2460 μs |  6.702 μs |  7.133 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.770 μs |   1.2771 μs |  0.0700 μs |  5.720 μs |  5.850 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.556 μs |   4.7124 μs |  0.2583 μs |  5.369 μs |  5.851 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.660 μs |   1.2640 μs |  0.0693 μs |  5.620 μs |  5.740 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.147 μs |   0.4267 μs |  0.0234 μs |  5.120 μs |  5.161 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **39.069 μs** | **141.4325 μs** |  **7.7524 μs** | **34.073 μs** | **48.000 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 47.429 μs | 206.3266 μs | 11.3095 μs | 35.727 μs | 58.300 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 41.925 μs | 163.5234 μs |  8.9633 μs | 31.619 μs | 47.900 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 44.572 μs | 253.4394 μs | 13.8919 μs | 36.377 μs | 60.612 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.411 μs | 140.1490 μs |  7.6820 μs | 26.679 μs | 40.275 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 34.961 μs | 181.7638 μs |  9.9631 μs | 23.924 μs | 43.290 μs |   14336 B |
