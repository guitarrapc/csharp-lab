```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.249 μs** |   **1.2771 μs** |  **0.0700 μs** |  **5.219 μs** |  **5.199 μs** |  **5.329 μs** |     **872 B** |
| StringFormat       | 1      |  6.102 μs |   2.2962 μs |  0.1259 μs |  6.062 μs |  6.001 μs |  6.243 μs |     896 B |
| InterpolatedFormat | 1      |  4.995 μs |   0.6578 μs |  0.0361 μs |  4.984 μs |  4.965 μs |  5.035 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.784 μs** | **399.6447 μs** | **21.9059 μs** | **36.338 μs** | **35.937 μs** | **74.078 μs** |   **14336 B** |
| StringFormat       | 100    | 46.103 μs | 174.1594 μs |  9.5463 μs | 41.608 μs | 39.634 μs | 57.067 μs |   16736 B |
| InterpolatedFormat | 100    | 36.187 μs | 311.8679 μs | 17.0945 μs | 27.922 μs | 24.796 μs | 55.843 μs |   14336 B |
