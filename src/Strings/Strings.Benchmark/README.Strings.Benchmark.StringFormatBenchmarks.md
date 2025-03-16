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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.832 μs** |   **9.392 μs** |  **0.5148 μs** |  **6.989 μs** |  **6.256 μs** |  **7.250 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.370 μs |   4.668 μs |  0.2559 μs |  7.354 μs |  7.123 μs |  7.634 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      | 11.966 μs | 167.265 μs |  9.1684 μs |  6.702 μs |  6.643 μs | 22.552 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.908 μs |  17.063 μs |  0.9353 μs |  5.460 μs |  5.281 μs |  6.983 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.563 μs |   5.920 μs |  0.3245 μs |  6.473 μs |  6.293 μs |  6.923 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.990 μs |   4.729 μs |  0.2592 μs |  5.040 μs |  4.709 μs |  5.220 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **42.206 μs** | **328.353 μs** | **17.9981 μs** | **31.880 μs** | **31.749 μs** | **62.988 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 42.982 μs | 190.309 μs | 10.4315 μs | 40.511 μs | 34.008 μs | 54.428 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 37.798 μs | 175.478 μs |  9.6186 μs | 32.452 μs | 32.040 μs | 48.902 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 39.327 μs | 100.461 μs |  5.5066 μs | 37.320 μs | 35.106 μs | 45.556 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 34.033 μs | 209.421 μs | 11.4791 μs | 27.471 μs | 27.341 μs | 47.288 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 31.462 μs | 222.187 μs | 12.1788 μs | 24.496 μs | 24.366 μs | 45.525 μs |   14048 B |
