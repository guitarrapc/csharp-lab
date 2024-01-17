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
| **CompositeFormat**    | **1**      |  **5.955 μs** |   **5.005 μs** | **0.2744 μs** |  **5.711 μs** |  **6.252 μs** |     **872 B** |
| StringFormat       | 1      |  5.984 μs |   7.435 μs | 0.4075 μs |  5.540 μs |  6.341 μs |     896 B |
| InterpolatedFormat | 1      |  5.731 μs |   2.687 μs | 0.1473 μs |  5.601 μs |  5.891 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.197 μs** | **128.905 μs** | **7.0657 μs** | **34.083 μs** | **46.356 μs** |   **14336 B** |
| StringFormat       | 100    | 38.594 μs | 154.447 μs | 8.4658 μs | 33.602 μs | 48.369 μs |   16736 B |
| InterpolatedFormat | 100    | 35.461 μs | 155.611 μs | 8.5296 μs | 30.431 μs | 45.309 μs |   14336 B |
