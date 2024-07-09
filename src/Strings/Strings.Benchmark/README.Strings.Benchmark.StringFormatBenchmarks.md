```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.225 μs** |   **1.552 μs** | **0.0850 μs** |  **6.142 μs** |  **6.312 μs** |     **872 B** |
| StringFormat       | 1      |  7.154 μs |  11.899 μs | 0.6522 μs |  6.402 μs |  7.574 μs |     896 B |
| InterpolatedFormat | 1      |  6.752 μs |   3.183 μs | 0.1745 μs |  6.601 μs |  6.943 μs |     872 B |
| **CompositeFormat**    | **100**    | **47.017 μs** |   **6.820 μs** | **0.3738 μs** | **46.777 μs** | **47.448 μs** |   **14336 B** |
| StringFormat       | 100    | 39.387 μs | 128.376 μs | 7.0367 μs | 35.115 μs | 47.508 μs |   16736 B |
| InterpolatedFormat | 100    | 36.738 μs | 159.512 μs | 8.7434 μs | 31.368 μs | 46.827 μs |   14336 B |
