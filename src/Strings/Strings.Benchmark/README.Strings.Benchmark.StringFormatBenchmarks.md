```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **8.609 μs** |   **9.893 μs** |  **0.5423 μs** |  **8.214 μs** |  **9.227 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  9.396 μs |  27.320 μs |  1.4975 μs |  8.271 μs | 11.095 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.172 μs |   6.970 μs |  0.3820 μs |  5.942 μs |  6.613 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  7.567 μs |  17.303 μs |  0.9484 μs |  6.862 μs |  8.646 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.074 μs |   8.783 μs |  0.4814 μs |  5.640 μs |  6.592 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.421 μs |  12.859 μs |  0.7048 μs |  4.900 μs |  6.223 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **59.297 μs** | **282.705 μs** | **15.4960 μs** | **48.441 μs** | **77.043 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 54.603 μs | 413.584 μs | 22.6700 μs | 35.086 μs | 79.469 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 54.515 μs | 142.999 μs |  7.8383 μs | 49.211 μs | 63.518 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 31.071 μs | 144.305 μs |  7.9098 μs | 26.459 μs | 40.204 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 43.873 μs | 112.389 μs |  6.1604 μs | 38.262 μs | 50.465 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 42.174 μs | 218.487 μs | 11.9760 μs | 35.011 μs | 55.999 μs |   14336 B |
