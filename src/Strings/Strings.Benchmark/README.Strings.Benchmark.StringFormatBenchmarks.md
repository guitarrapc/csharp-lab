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
| Method             | Runtime  | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.786 μs** |   **9.6723 μs** | **0.5302 μs** |  **6.221 μs** |  **7.274 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.792 μs |  10.2025 μs | 0.5592 μs |  6.402 μs |  7.433 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.094 μs |   1.1900 μs | 0.0652 μs |  6.020 μs |  6.142 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.188 μs |   4.6616 μs | 0.2555 μs |  5.931 μs |  6.442 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.154 μs |   7.8096 μs | 0.4281 μs |  5.670 μs |  6.482 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.120 μs |   0.9757 μs | 0.0535 μs |  5.059 μs |  5.160 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **44.184 μs** | **161.9376 μs** | **8.8763 μs** | **33.955 μs** | **49.864 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 53.419 μs | 180.0291 μs | 9.8680 μs | 46.371 μs | 64.697 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.368 μs | 148.8715 μs | 8.1602 μs | 31.388 μs | 45.785 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 30.672 μs | 156.3655 μs | 8.5709 μs | 25.559 μs | 40.567 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 32.301 μs | 158.6826 μs | 8.6979 μs | 27.021 μs | 42.340 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 28.680 μs | 133.0200 μs | 7.2913 μs | 24.386 μs | 37.099 μs |   14336 B |
