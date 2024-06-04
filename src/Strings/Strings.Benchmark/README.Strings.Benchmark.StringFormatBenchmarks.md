```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **7.611 μs** |   **9.953 μs** |  **0.5455 μs** |  **7.494 μs** |  **7.134 μs** |  **8.206 μs** |     **872 B** |
| StringFormat       | 1      |  6.846 μs |  13.384 μs |  0.7336 μs |  6.532 μs |  6.321 μs |  7.684 μs |     896 B |
| InterpolatedFormat | 1      |  6.538 μs |   7.195 μs |  0.3944 μs |  6.418 μs |  6.217 μs |  6.978 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.438 μs** | **209.954 μs** | **11.5083 μs** | **34.384 μs** | **33.221 μs** | **53.710 μs** |   **14336 B** |
| StringFormat       | 100    | 48.337 μs | 419.383 μs | 22.9878 μs | 35.326 μs | 34.805 μs | 74.879 μs |   16736 B |
| InterpolatedFormat | 100    | 47.919 μs | 227.414 μs | 12.4653 μs | 41.096 μs | 40.354 μs | 62.306 μs |   14336 B |
