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
| **CompositeFormat**    | **1**      |  **5.303 μs** |   **1.836 μs** |  **0.1007 μs** |  **5.290 μs** |  **5.210 μs** |  **5.410 μs** |     **872 B** |
| StringFormat       | 1      |  6.329 μs |   1.562 μs |  0.0856 μs |  6.363 μs |  6.232 μs |  6.393 μs |     896 B |
| InterpolatedFormat | 1      |  5.531 μs |   8.555 μs |  0.4689 μs |  5.270 μs |  5.250 μs |  6.072 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.721 μs** | **235.800 μs** | **12.9250 μs** | **36.324 μs** | **36.193 μs** | **58.645 μs** |   **14048 B** |
| StringFormat       | 100    | 46.177 μs | 237.687 μs | 13.0284 μs | 39.024 μs | 38.292 μs | 61.215 μs |   16736 B |
| InterpolatedFormat | 100    | 31.809 μs | 208.306 μs | 11.4180 μs | 25.218 μs | 25.216 μs | 44.993 μs |   14336 B |
