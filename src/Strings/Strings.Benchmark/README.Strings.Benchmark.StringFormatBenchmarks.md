```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.866 μs** |   **6.346 μs** | **0.3479 μs** |  **6.582 μs** |  **7.254 μs** |     **872 B** |
| StringFormat       | 1      |  6.469 μs |   1.320 μs | 0.0723 μs |  6.423 μs |  6.553 μs |     896 B |
| InterpolatedFormat | 1      |  6.712 μs |   2.454 μs | 0.1345 μs |  6.602 μs |  6.862 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.928 μs** | **131.074 μs** | **7.1846 μs** | **31.089 μs** | **44.183 μs** |   **14336 B** |
| StringFormat       | 100    | 39.128 μs | 122.023 μs | 6.6885 μs | 34.539 μs | 46.803 μs |   16736 B |
| InterpolatedFormat | 100    | 36.172 μs | 124.254 μs | 6.8108 μs | 32.214 μs | 44.036 μs |   14336 B |
