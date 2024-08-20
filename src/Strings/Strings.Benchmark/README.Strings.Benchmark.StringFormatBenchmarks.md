```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.051 μs** |   **1.6215 μs** |  **0.0889 μs** |  **5.981 μs** |  **6.151 μs** |     **872 B** |
| StringFormat       | 1      |  6.221 μs |   0.7297 μs |  0.0400 μs |  6.181 μs |  6.261 μs |     896 B |
| InterpolatedFormat | 1      |  6.090 μs |   5.9203 μs |  0.3245 μs |  5.715 μs |  6.296 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.903 μs** | **207.2133 μs** | **11.3581 μs** | **43.290 μs** | **63.018 μs** |   **14336 B** |
| StringFormat       | 100    | 37.420 μs | 125.8396 μs |  6.8977 μs | 33.403 μs | 45.385 μs |   16736 B |
| InterpolatedFormat | 100    | 35.521 μs | 131.0550 μs |  7.1836 μs | 31.324 μs | 43.816 μs |   14336 B |
