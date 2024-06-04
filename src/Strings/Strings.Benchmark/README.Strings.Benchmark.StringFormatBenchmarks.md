```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.316 μs** |   **8.546 μs** |  **0.4684 μs** |  **6.001 μs** |  **6.854 μs** |     **872 B** |
| StringFormat       | 1      |  7.013 μs |  11.869 μs |  0.6506 μs |  6.262 μs |  7.413 μs |     896 B |
| InterpolatedFormat | 1      |  6.179 μs |  13.132 μs |  0.7198 μs |  5.681 μs |  7.004 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.653 μs** | **221.683 μs** | **12.1512 μs** | **42.089 μs** | **63.669 μs** |   **14336 B** |
| StringFormat       | 100    | 37.668 μs | 126.055 μs |  6.9095 μs | 33.654 μs | 45.646 μs |   16736 B |
| InterpolatedFormat | 100    | 34.925 μs | 119.875 μs |  6.5708 μs | 30.536 μs | 42.479 μs |   14336 B |
