```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.988 μs** |   **2.874 μs** |  **0.1575 μs** |  **5.811 μs** |  **6.112 μs** |     **872 B** |
| StringFormat       | 1      |  7.339 μs |   1.430 μs |  0.0784 μs |  7.248 μs |  7.388 μs |     896 B |
| InterpolatedFormat | 1      |  6.576 μs |   5.668 μs |  0.3107 μs |  6.323 μs |  6.923 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.248 μs** | **155.548 μs** |  **8.5261 μs** | **32.882 μs** | **48.080 μs** |   **14336 B** |
| StringFormat       | 100    | 54.362 μs | 236.759 μs | 12.9776 μs | 45.515 μs | 69.260 μs |   16736 B |
| InterpolatedFormat | 100    | 38.760 μs | 201.995 μs | 11.0721 μs | 31.990 μs | 51.537 μs |   14336 B |
