```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.165 μs** |   **7.152 μs** | **0.3920 μs** |  **5.881 μs** |  **6.612 μs** |     **872 B** |
| StringFormat       | 1      |  6.575 μs |   2.027 μs | 0.1111 μs |  6.471 μs |  6.692 μs |     896 B |
| InterpolatedFormat | 1      |  6.331 μs |   7.369 μs | 0.4039 μs |  5.961 μs |  6.762 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.189 μs** | **156.978 μs** | **8.6045 μs** | **33.002 μs** | **48.121 μs** |   **14336 B** |
| StringFormat       | 100    | 69.235 μs | 168.592 μs | 9.2411 μs | 63.568 μs | 79.899 μs |   16736 B |
| InterpolatedFormat | 100    | 35.475 μs | 120.916 μs | 6.6278 μs | 30.573 μs | 43.016 μs |   14336 B |
