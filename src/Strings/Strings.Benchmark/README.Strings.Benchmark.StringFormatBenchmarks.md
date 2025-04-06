```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.032 μs** |  **16.0425 μs** |  **0.8793 μs** |  **5.671 μs** |  **5.390 μs** |  **7.034 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.165 μs |   4.0442 μs |  0.2217 μs |  7.139 μs |  6.958 μs |  7.399 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.314 μs |   0.3872 μs |  0.0212 μs |  5.320 μs |  5.290 μs |  5.331 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.454 μs |   1.5191 μs |  0.0833 μs |  5.481 μs |  5.361 μs |  5.521 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  6.424 μs |   3.8817 μs |  0.2128 μs |  6.487 μs |  6.186 μs |  6.598 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.654 μs |   2.6311 μs |  0.1442 μs |  4.694 μs |  4.494 μs |  4.774 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **45.756 μs** | **278.7438 μs** | **15.2789 μs** | **48.712 μs** | **29.215 μs** | **59.342 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 43.723 μs | 210.4876 μs | 11.5375 μs | 46.077 μs | 31.190 μs | 53.902 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 38.254 μs | 152.6242 μs |  8.3658 μs | 40.480 μs | 29.000 μs | 45.281 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 34.536 μs | 335.0298 μs | 18.3641 μs | 24.191 μs | 23.680 μs | 55.739 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.360 μs | 135.1060 μs |  7.4056 μs | 27.256 μs | 26.916 μs | 39.910 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 31.320 μs | 157.9739 μs |  8.6591 μs | 31.053 μs | 22.797 μs | 40.109 μs |   14336 B |
