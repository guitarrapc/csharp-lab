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
| **CompositeFormat**    | **1**      |  **5.372 μs** |   **2.834 μs** |  **0.1553 μs** |  **5.419 μs** |  **5.199 μs** |  **5.499 μs** |     **872 B** |
| StringFormat       | 1      |  6.176 μs |   1.177 μs |  0.0645 μs |  6.203 μs |  6.102 μs |  6.222 μs |     896 B |
| InterpolatedFormat | 1      |  5.063 μs |   2.667 μs |  0.1462 μs |  5.080 μs |  4.910 μs |  5.200 μs |     872 B |
| **CompositeFormat**    | **100**    | **34.038 μs** | **218.286 μs** | **11.9650 μs** | **27.145 μs** | **27.116 μs** | **47.855 μs** |   **14336 B** |
| StringFormat       | 100    | 33.298 μs | 168.856 μs |  9.2556 μs | 28.823 μs | 27.131 μs | 43.941 μs |   16736 B |
| InterpolatedFormat | 100    | 31.528 μs | 184.787 μs | 10.1288 μs | 26.044 μs | 25.323 μs | 43.216 μs |   14336 B |
