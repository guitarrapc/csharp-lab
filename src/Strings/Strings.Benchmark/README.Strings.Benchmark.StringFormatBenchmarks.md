```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.963 μs** |   **8.057 μs** |  **0.4416 μs** |  **6.077 μs** |  **5.476 μs** |  **6.337 μs** |     **584 B** |
| StringFormat       | 1      |  6.378 μs |  18.056 μs |  0.9897 μs |  5.921 μs |  5.700 μs |  7.514 μs |     896 B |
| InterpolatedFormat | 1      |  5.457 μs |  10.358 μs |  0.5678 μs |  5.160 μs |  5.100 μs |  6.112 μs |     872 B |
| **CompositeFormat**    | **100**    | **30.891 μs** | **134.275 μs** |  **7.3601 μs** | **27.111 μs** | **26.189 μs** | **39.373 μs** |   **14048 B** |
| StringFormat       | 100    | 56.937 μs | 582.106 μs | 31.9072 μs | 39.002 μs | 38.032 μs | 93.775 μs |   16736 B |
| InterpolatedFormat | 100    | 32.086 μs | 209.721 μs | 11.4955 μs | 25.873 μs | 25.032 μs | 45.350 μs |   14336 B |
