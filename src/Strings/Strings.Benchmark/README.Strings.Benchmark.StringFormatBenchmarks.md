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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **7.517 μs** |  **30.918 μs** |  **1.6947 μs** |  **6.762 μs** |  **6.331 μs** |  **9.458 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.452 μs |   4.205 μs |  0.2305 μs |  6.452 μs |  6.221 μs |  6.683 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.994 μs |   7.525 μs |  0.4125 μs |  6.954 μs |  6.603 μs |  7.425 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.651 μs |   2.565 μs |  0.1406 μs |  5.591 μs |  5.551 μs |  5.812 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.665 μs |   6.419 μs |  0.3518 μs |  5.565 μs |  5.374 μs |  6.056 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  6.582 μs |  20.616 μs |  1.1301 μs |  6.001 μs |  5.860 μs |  7.884 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **49.600 μs** | **230.519 μs** | **12.6355 μs** | **42.380 μs** | **42.230 μs** | **64.190 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 37.988 μs | 138.262 μs |  7.5786 μs | 34.004 μs | 33.233 μs | 46.727 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 35.402 μs | 129.410 μs |  7.0934 μs | 31.468 μs | 31.148 μs | 43.591 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 34.177 μs | 258.034 μs | 14.1437 μs | 26.329 μs | 25.698 μs | 50.505 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.798 μs | 170.363 μs |  9.3382 μs | 27.802 μs | 27.020 μs | 43.571 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.535 μs | 148.838 μs |  8.1583 μs | 25.267 μs | 24.396 μs | 38.943 μs |   14048 B |
