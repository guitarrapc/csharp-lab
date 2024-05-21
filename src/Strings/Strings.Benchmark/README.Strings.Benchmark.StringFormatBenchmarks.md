```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.078 μs** |   **4.025 μs** |  **0.2206 μs** |  **5.972 μs** |  **5.931 μs** |  **6.332 μs** |     **872 B** |
| StringFormat       | 1      |  6.356 μs |   1.369 μs |  0.0751 μs |  6.353 μs |  6.283 μs |  6.433 μs |     896 B |
| InterpolatedFormat | 1      |  6.666 μs |   1.464 μs |  0.0803 μs |  6.673 μs |  6.582 μs |  6.742 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.414 μs** | **297.019 μs** | **16.2806 μs** | **43.090 μs** | **42.939 μs** | **71.213 μs** |   **14336 B** |
| StringFormat       | 100    | 39.770 μs | 151.396 μs |  8.2985 μs | 35.075 μs | 34.884 μs | 49.352 μs |   16736 B |
| InterpolatedFormat | 100    | 42.002 μs | 313.082 μs | 17.1611 μs | 32.391 μs | 31.800 μs | 61.815 μs |   14336 B |
