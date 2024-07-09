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
| **CompositeFormat**    | **1**      |  **5.951 μs** |   **6.411 μs** | **0.3514 μs** |  **5.661 μs** |  **6.342 μs** |     **872 B** |
| StringFormat       | 1      |  6.139 μs |   1.583 μs | 0.0868 μs |  6.062 μs |  6.233 μs |     896 B |
| InterpolatedFormat | 1      |  5.754 μs |   6.438 μs | 0.3529 μs |  5.540 μs |  6.161 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.213 μs** | **161.316 μs** | **8.8423 μs** | **31.649 μs** | **47.409 μs** |   **14336 B** |
| StringFormat       | 100    | 38.740 μs | 171.328 μs | 9.3911 μs | 33.223 μs | 49.583 μs |   16736 B |
| InterpolatedFormat | 100    | 36.999 μs | 118.569 μs | 6.4992 μs | 31.599 μs | 44.212 μs |   14336 B |
