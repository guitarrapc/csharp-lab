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
| **CompositeFormat**    | **1**      |  **6.850 μs** |   **8.693 μs** |  **0.4765 μs** |  **6.423 μs** |  **7.364 μs** |     **872 B** |
| StringFormat       | 1      |  6.058 μs |   6.409 μs |  0.3513 μs |  5.721 μs |  6.422 μs |     896 B |
| InterpolatedFormat | 1      |  6.685 μs |   2.296 μs |  0.1258 μs |  6.552 μs |  6.802 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.574 μs** | **250.161 μs** | **13.7122 μs** | **42.359 μs** | **66.404 μs** |   **14336 B** |
| StringFormat       | 100    | 36.838 μs | 118.718 μs |  6.5073 μs | 33.071 μs | 44.352 μs |   16736 B |
| InterpolatedFormat | 100    | 34.354 μs | 116.506 μs |  6.3861 μs | 30.647 μs | 41.728 μs |   14336 B |
