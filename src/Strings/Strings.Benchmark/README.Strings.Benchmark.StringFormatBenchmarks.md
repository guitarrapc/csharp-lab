```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.691 μs** |   **7.022 μs** |  **0.3849 μs** |  **5.521 μs** |  **5.421 μs** |  **6.132 μs** |     **872 B** |
| StringFormat       | 1      |  6.443 μs |   1.759 μs |  0.0964 μs |  6.483 μs |  6.333 μs |  6.513 μs |     608 B |
| InterpolatedFormat | 1      |  5.694 μs |   2.894 μs |  0.1587 μs |  5.730 μs |  5.520 μs |  5.831 μs |     872 B |
| **CompositeFormat**    | **100**    | **34.520 μs** | **272.382 μs** | **14.9302 μs** | **26.364 μs** | **25.444 μs** | **51.752 μs** |   **14336 B** |
| StringFormat       | 100    | 32.110 μs | 142.312 μs |  7.8006 μs | 27.702 μs | 27.512 μs | 41.117 μs |   16448 B |
| InterpolatedFormat | 100    | 30.386 μs | 179.193 μs |  9.8222 μs | 24.726 μs | 24.705 μs | 41.728 μs |   14336 B |
