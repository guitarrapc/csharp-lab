```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.189 μs** |   **1.215 μs** | **0.0666 μs** |  **6.132 μs** |  **6.262 μs** |     **872 B** |
| StringFormat       | 1      |  6.731 μs |  10.992 μs | 0.6025 μs |  6.256 μs |  7.409 μs |     896 B |
| InterpolatedFormat | 1      |  6.068 μs |   2.229 μs | 0.1222 μs |  5.961 μs |  6.201 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.378 μs** | **126.007 μs** | **6.9069 μs** | **32.301 μs** | **44.353 μs** |   **14336 B** |
| StringFormat       | 100    | 37.393 μs | 143.372 μs | 7.8587 μs | 32.752 μs | 46.467 μs |   16736 B |
| InterpolatedFormat | 100    | 35.279 μs | 125.018 μs | 6.8526 μs | 30.837 μs | 43.171 μs |   14336 B |
