```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.201 μs** |   **4.188 μs** |  **0.2296 μs** |  **6.000 μs** |  **6.451 μs** |     **872 B** |
| StringFormat       | 1      |  6.391 μs |   2.210 μs |  0.1212 μs |  6.281 μs |  6.521 μs |     896 B |
| InterpolatedFormat | 1      |  6.580 μs |   3.396 μs |  0.1862 μs |  6.383 μs |  6.753 μs |     872 B |
| **CompositeFormat**    | **100**    | **42.239 μs** | **162.089 μs** |  **8.8846 μs** | **32.602 μs** | **50.104 μs** |   **14336 B** |
| StringFormat       | 100    | 52.900 μs | 262.380 μs | 14.3820 μs | 44.347 μs | 69.504 μs |   16736 B |
| InterpolatedFormat | 100    | 34.988 μs | 125.167 μs |  6.8608 μs | 30.927 μs | 42.909 μs |   14336 B |
