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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.774 μs** |   **1.629 μs** |  **0.0893 μs** |  **5.821 μs** |  **5.671 μs** |  **5.830 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.227 μs |   1.951 μs |  0.1069 μs |  7.284 μs |  7.104 μs |  7.294 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.979 μs |  11.841 μs |  0.6490 μs |  5.645 μs |  5.565 μs |  6.727 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.011 μs |   6.634 μs |  0.3636 μs |  5.880 μs |  5.731 μs |  6.423 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.254 μs |   8.891 μs |  0.4874 μs |  5.341 μs |  4.729 μs |  5.692 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.672 μs |  15.081 μs |  0.8267 μs |  4.438 μs |  3.987 μs |  5.590 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **54.271 μs** | **380.787 μs** | **20.8722 μs** | **42.669 μs** | **41.778 μs** | **78.367 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 46.227 μs | 402.384 μs | 22.0560 μs | 33.562 μs | 33.422 μs | 71.695 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.392 μs | 135.458 μs |  7.4249 μs | 32.211 μs | 32.001 μs | 44.965 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 41.975 μs | 221.382 μs | 12.1347 μs | 35.205 μs | 34.735 μs | 55.984 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.475 μs | 153.972 μs |  8.4397 μs | 27.673 μs | 27.532 μs | 42.220 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.117 μs | 145.820 μs |  7.9929 μs | 23.659 μs | 23.348 μs | 37.345 μs |   14336 B |
