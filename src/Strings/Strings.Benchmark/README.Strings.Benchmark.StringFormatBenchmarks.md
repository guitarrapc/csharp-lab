```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.425 μs** |   **8.334 μs** |  **0.4568 μs** |  **6.151 μs** |  **6.952 μs** |     **872 B** |
| StringFormat       | 1      |  6.666 μs |   1.916 μs |  0.1050 μs |  6.562 μs |  6.772 μs |     896 B |
| InterpolatedFormat | 1      |  6.260 μs |   3.198 μs |  0.1753 μs |  6.066 μs |  6.407 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.344 μs** | **267.526 μs** | **14.6640 μs** | **42.553 μs** | **68.272 μs** |   **14336 B** |
| StringFormat       | 100    | 37.403 μs | 125.367 μs |  6.8718 μs | 33.242 μs | 45.335 μs |   16736 B |
| InterpolatedFormat | 100    | 36.820 μs | 172.529 μs |  9.4569 μs | 30.969 μs | 47.730 μs |   14336 B |
