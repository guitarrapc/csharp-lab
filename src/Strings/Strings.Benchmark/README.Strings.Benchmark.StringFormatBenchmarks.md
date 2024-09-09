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
| **CompositeFormat**    | **1**      |  **6.041 μs** |   **2.217 μs** |  **0.1215 μs** |  **5.970 μs** |  **6.181 μs** |     **872 B** |
| StringFormat       | 1      |  6.378 μs |   2.320 μs |  0.1272 μs |  6.281 μs |  6.522 μs |     896 B |
| InterpolatedFormat | 1      |  6.409 μs |   8.349 μs |  0.4576 μs |  5.912 μs |  6.813 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.994 μs** | **210.045 μs** | **11.5133 μs** | **44.088 μs** | **64.285 μs** |   **14336 B** |
| StringFormat       | 100    | 39.951 μs | 162.141 μs |  8.8875 μs | 34.795 μs | 50.213 μs |   16736 B |
| InterpolatedFormat | 100    | 36.340 μs | 136.350 μs |  7.4738 μs | 32.014 μs | 44.969 μs |   14336 B |
