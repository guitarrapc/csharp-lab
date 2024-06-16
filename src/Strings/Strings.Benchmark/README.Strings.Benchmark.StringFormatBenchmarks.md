```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.186 μs** |  **11.924 μs** | **0.6536 μs** |  **5.681 μs** |  **6.924 μs** |     **872 B** |
| StringFormat       | 1      |  6.513 μs |   5.390 μs | 0.2954 μs |  6.322 μs |  6.853 μs |     896 B |
| InterpolatedFormat | 1      |  6.389 μs |   9.678 μs | 0.5305 μs |  5.791 μs |  6.803 μs |     872 B |
| **CompositeFormat**    | **100**    | **63.516 μs** | **131.493 μs** | **7.2076 μs** | **58.640 μs** | **71.795 μs** |   **14336 B** |
| StringFormat       | 100    | 40.132 μs | 166.902 μs | 9.1485 μs | 34.815 μs | 50.696 μs |   16736 B |
| InterpolatedFormat | 100    | 35.920 μs | 148.505 μs | 8.1401 μs | 30.957 μs | 45.314 μs |   14336 B |
