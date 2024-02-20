```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.106 μs** |   **6.5102 μs** |  **0.3568 μs** |  **5.696 μs** |  **6.338 μs** |     **872 B** |
| StringFormat       | 1      |  6.434 μs |   0.7625 μs |  0.0418 μs |  6.386 μs |  6.466 μs |     896 B |
| InterpolatedFormat | 1      |  5.794 μs |   1.9607 μs |  0.1075 μs |  5.700 μs |  5.911 μs |     872 B |
| **CompositeFormat**    | **100**    | **41.902 μs** | **114.5224 μs** |  **6.2774 μs** | **34.655 μs** | **45.665 μs** |   **14336 B** |
| StringFormat       | 100    | 38.324 μs | 124.4053 μs |  6.8191 μs | 34.223 μs | 46.196 μs |   16736 B |
| InterpolatedFormat | 100    | 48.531 μs | 235.0560 μs | 12.8842 μs | 40.997 μs | 63.408 μs |   14336 B |
