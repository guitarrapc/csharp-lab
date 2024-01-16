```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.810 μs** |   **4.428 μs** |  **0.2427 μs** |  **5.706 μs** |  **5.636 μs** |  **6.087 μs** |     **872 B** |
| StringFormat       | 1      |  7.169 μs |  12.021 μs |  0.6589 μs |  7.343 μs |  6.441 μs |  7.724 μs |     896 B |
| InterpolatedFormat | 1      |  6.188 μs |   8.710 μs |  0.4774 μs |  5.991 μs |  5.840 μs |  6.732 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.030 μs** | **587.263 μs** | **32.1899 μs** | **32.455 μs** | **32.436 μs** | **88.200 μs** |   **14336 B** |
| StringFormat       | 100    | 37.905 μs | 125.350 μs |  6.8708 μs | 34.084 μs | 33.794 μs | 45.837 μs |   16736 B |
| InterpolatedFormat | 100    | 34.408 μs | 128.298 μs |  7.0324 μs | 30.678 μs | 30.027 μs | 42.520 μs |   14336 B |
