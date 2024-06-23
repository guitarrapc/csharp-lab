```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.551 μs** |   **6.353 μs** |  **0.3482 μs** |  **6.501 μs** |  **6.231 μs** |  **6.922 μs** |     **872 B** |
| StringFormat       | 1      |  6.997 μs |  11.368 μs |  0.6231 μs |  7.285 μs |  6.282 μs |  7.424 μs |     896 B |
| InterpolatedFormat | 1      |  5.780 μs |   3.831 μs |  0.2100 μs |  5.781 μs |  5.570 μs |  5.990 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.779 μs** | **128.716 μs** |  **7.0554 μs** | **32.842 μs** | **32.572 μs** | **44.925 μs** |   **14336 B** |
| StringFormat       | 100    | 46.350 μs | 352.625 μs | 19.3286 μs | 35.346 μs | 35.036 μs | 68.668 μs |   16736 B |
| InterpolatedFormat | 100    | 47.953 μs | 198.126 μs | 10.8600 μs | 41.699 μs | 41.669 μs | 60.493 μs |   14336 B |
