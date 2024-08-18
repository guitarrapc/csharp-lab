```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.111 μs** |   **2.737 μs** |  **0.1500 μs** |  **5.961 μs** |  **6.261 μs** |     **872 B** |
| StringFormat       | 1      |  6.578 μs |   4.903 μs |  0.2688 μs |  6.371 μs |  6.882 μs |     896 B |
| InterpolatedFormat | 1      |  6.874 μs |   9.529 μs |  0.5223 μs |  6.407 μs |  7.438 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.225 μs** | **171.491 μs** |  **9.4000 μs** | **32.150 μs** | **49.052 μs** |   **14336 B** |
| StringFormat       | 100    | 38.263 μs | 124.617 μs |  6.8307 μs | 33.738 μs | 46.120 μs |   16736 B |
| InterpolatedFormat | 100    | 37.782 μs | 198.547 μs | 10.8831 μs | 31.494 μs | 50.349 μs |   14336 B |
