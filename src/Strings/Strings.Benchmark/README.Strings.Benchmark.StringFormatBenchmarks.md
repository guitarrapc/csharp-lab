```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.336 μs** |   **0.5903 μs** |  **0.0324 μs** |  **5.350 μs** |  **5.299 μs** |  **5.359 μs** |     **584 B** |
| StringFormat       | 1      |  5.539 μs |   2.1829 μs |  0.1197 μs |  5.486 μs |  5.455 μs |  5.676 μs |     896 B |
| InterpolatedFormat | 1      |  5.163 μs |   1.2147 μs |  0.0666 μs |  5.180 μs |  5.090 μs |  5.220 μs |     872 B |
| **CompositeFormat**    | **100**    | **46.744 μs** | **329.4519 μs** | **18.0584 μs** | **36.338 μs** | **36.298 μs** | **67.596 μs** |   **14336 B** |
| StringFormat       | 100    | 36.492 μs | 243.6156 μs | 13.3534 μs | 29.095 μs | 28.474 μs | 51.907 μs |   16736 B |
| InterpolatedFormat | 100    | 38.235 μs | 107.6450 μs |  5.9004 μs | 35.216 μs | 34.455 μs | 45.034 μs |   14048 B |
