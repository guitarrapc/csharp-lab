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
| **CompositeFormat**    | **1**      |  **6.302 μs** |   **2.107 μs** |  **0.1155 μs** |  **6.172 μs** |  **6.392 μs** |     **872 B** |
| StringFormat       | 1      |  7.009 μs |   8.599 μs |  0.4713 μs |  6.472 μs |  7.353 μs |     896 B |
| InterpolatedFormat | 1      |  6.833 μs |   1.095 μs |  0.0600 μs |  6.774 μs |  6.894 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.552 μs** | **314.333 μs** | **17.2296 μs** | **38.828 μs** | **69.426 μs** |   **14336 B** |
| StringFormat       | 100    | 41.639 μs | 142.561 μs |  7.8143 μs | 36.850 μs | 50.656 μs |   16736 B |
| InterpolatedFormat | 100    | 38.761 μs | 160.027 μs |  8.7716 μs | 33.487 μs | 48.886 μs |   14336 B |
