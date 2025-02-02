```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.961 μs** |   **4.135 μs** |  **0.2266 μs** |  **5.700 μs** |  **6.112 μs** |     **872 B** |
| StringFormat       | 1      |  6.303 μs |   5.803 μs |  0.3181 μs |  5.942 μs |  6.543 μs |     608 B |
| InterpolatedFormat | 1      |  5.300 μs |  12.753 μs |  0.6991 μs |  4.769 μs |  6.092 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.712 μs** | **138.904 μs** |  **7.6138 μs** | **44.053 μs** | **57.498 μs** |   **14048 B** |
| StringFormat       | 100    | 32.474 μs | 140.837 μs |  7.7198 μs | 28.003 μs | 41.389 μs |   16736 B |
| InterpolatedFormat | 100    | 38.232 μs | 221.087 μs | 12.1185 μs | 25.428 μs | 49.523 μs |   14048 B |
