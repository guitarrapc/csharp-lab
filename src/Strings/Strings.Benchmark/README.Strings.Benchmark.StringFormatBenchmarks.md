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
| **CompositeFormat**    | **1**      |  **5.457 μs** |   **5.574 μs** |  **0.3055 μs** |  **5.461 μs** |  **5.150 μs** |  **5.761 μs** |     **584 B** |
| StringFormat       | 1      |  5.556 μs |   2.588 μs |  0.1418 μs |  5.480 μs |  5.469 μs |  5.720 μs |     896 B |
| InterpolatedFormat | 1      |  8.054 μs |  24.662 μs |  1.3518 μs |  8.375 μs |  6.571 μs |  9.217 μs |     872 B |
| **CompositeFormat**    | **100**    | **47.898 μs** | **397.453 μs** | **21.7857 μs** | **36.884 μs** | **33.819 μs** | **72.992 μs** |   **14336 B** |
| StringFormat       | 100    | 50.564 μs | 193.833 μs | 10.6246 μs | 54.101 μs | 38.622 μs | 58.969 μs |   16736 B |
| InterpolatedFormat | 100    | 49.311 μs | 306.050 μs | 16.7756 μs | 43.971 μs | 35.856 μs | 68.107 μs |   14336 B |
