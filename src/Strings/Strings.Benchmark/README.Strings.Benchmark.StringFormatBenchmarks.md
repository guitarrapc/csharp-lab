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
| **CompositeFormat**    | **1**      |  **5.196 μs** |   **1.115 μs** |  **0.0611 μs** |  **5.209 μs** |  **5.129 μs** |  **5.249 μs** |     **872 B** |
| StringFormat       | 1      |  5.634 μs |   7.299 μs |  0.4001 μs |  5.510 μs |  5.310 μs |  6.081 μs |     896 B |
| InterpolatedFormat | 1      |  4.813 μs |   1.177 μs |  0.0645 μs |  4.840 μs |  4.739 μs |  4.859 μs |     872 B |
| **CompositeFormat**    | **100**    | **41.712 μs** | **203.043 μs** | **11.1295 μs** | **35.386 μs** | **35.187 μs** | **54.562 μs** |   **14336 B** |
| StringFormat       | 100    | 34.685 μs | 240.054 μs | 13.1582 μs | 27.442 μs | 26.741 μs | 49.873 μs |   16736 B |
| InterpolatedFormat | 100    | 33.571 μs | 297.211 μs | 16.2912 μs | 24.210 μs | 24.120 μs | 52.382 μs |   14336 B |
