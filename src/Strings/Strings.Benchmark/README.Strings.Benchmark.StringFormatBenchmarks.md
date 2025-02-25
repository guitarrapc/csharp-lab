```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **5.944 μs** |   **2.834 μs** | **0.1553 μs** |  **5.771 μs** |  **6.071 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.080 μs |   3.812 μs | 0.2090 μs |  6.853 μs |  7.264 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.278 μs |  12.753 μs | 0.6990 μs |  5.821 μs |  7.083 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.994 μs |   1.225 μs | 0.0672 μs |  5.950 μs |  6.071 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.496 μs |   1.820 μs | 0.0998 μs |  5.420 μs |  5.609 μs |     272 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.704 μs |   9.589 μs | 0.5256 μs |  5.099 μs |  6.051 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **36.209 μs** | **128.025 μs** | **7.0175 μs** | **32.028 μs** | **44.311 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.453 μs | 121.207 μs | 6.6437 μs | 34.399 μs | 46.120 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.143 μs | 143.153 μs | 7.8467 μs | 31.468 μs | 45.202 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 31.478 μs | 176.276 μs | 9.6623 μs | 25.567 μs | 42.628 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 44.758 μs | 166.118 μs | 9.1055 μs | 35.812 μs | 54.014 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.997 μs | 150.006 μs | 8.2223 μs | 24.155 μs | 38.491 μs |   14336 B |
