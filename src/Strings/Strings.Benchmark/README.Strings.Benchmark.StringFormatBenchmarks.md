```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.137 μs** |   **1.0794 μs** |  **0.0592 μs** |  **6.070 μs** |  **6.181 μs** |     **872 B** |
| StringFormat       | 1      |  7.240 μs |  14.3388 μs |  0.7860 μs |  6.392 μs |  7.944 μs |     896 B |
| InterpolatedFormat | 1      |  6.152 μs |   0.3649 μs |  0.0200 μs |  6.132 μs |  6.172 μs |     872 B |
| **CompositeFormat**    | **100**    | **65.410 μs** | **209.1659 μs** | **11.4651 μs** | **58.700 μs** | **78.648 μs** |   **14336 B** |
| StringFormat       | 100    | 55.528 μs | 255.9789 μs | 14.0311 μs | 45.165 μs | 71.495 μs |   16736 B |
| InterpolatedFormat | 100    | 54.301 μs | 364.1024 μs | 19.9577 μs | 31.989 μs | 70.451 μs |   14336 B |
