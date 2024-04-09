```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.301 μs** |   **8.976 μs** |  **0.4920 μs** |  **6.006 μs** |  **6.869 μs** |     **872 B** |
| StringFormat       | 1      |  6.081 μs |   1.441 μs |  0.0790 μs |  5.991 μs |  6.140 μs |     896 B |
| InterpolatedFormat | 1      |  5.801 μs |   1.150 μs |  0.0630 μs |  5.751 μs |  5.872 μs |     872 B |
| **CompositeFormat**    | **100**    | **39.307 μs** | **224.573 μs** | **12.3096 μs** | **32.130 μs** | **53.521 μs** |   **14336 B** |
| StringFormat       | 100    | 37.257 μs | 133.027 μs |  7.2917 μs | 33.032 μs | 45.677 μs |   16736 B |
| InterpolatedFormat | 100    | 34.525 μs | 123.627 μs |  6.7764 μs | 30.547 μs | 42.349 μs |   14336 B |
