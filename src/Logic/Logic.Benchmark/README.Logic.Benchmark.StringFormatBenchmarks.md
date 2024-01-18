```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.618 μs** |   **8.032 μs** | **0.4402 μs** |  **6.241 μs** |  **7.102 μs** |     **872 B** |
| StringFormat       | 1      |  7.433 μs |   1.558 μs | 0.0854 μs |  7.353 μs |  7.523 μs |     896 B |
| InterpolatedFormat | 1      |  6.771 μs |   4.941 μs | 0.2708 μs |  6.567 μs |  7.078 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.971 μs** | **118.941 μs** | **6.5195 μs** | **33.136 μs** | **44.498 μs** |   **14336 B** |
| StringFormat       | 100    | 38.368 μs | 148.688 μs | 8.1501 μs | 33.603 μs | 47.779 μs |   16736 B |
| InterpolatedFormat | 100    | 34.664 μs | 122.581 μs | 6.7191 μs | 30.566 μs | 42.418 μs |   14336 B |
