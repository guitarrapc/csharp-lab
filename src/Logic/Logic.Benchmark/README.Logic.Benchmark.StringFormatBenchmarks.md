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
| **CompositeFormat**    | **1**      |  **6.368 μs** |   **2.753 μs** | **0.1509 μs** |  **6.211 μs** |  **6.512 μs** |     **872 B** |
| StringFormat       | 1      |  6.858 μs |  12.755 μs | 0.6991 μs |  6.377 μs |  7.660 μs |     896 B |
| InterpolatedFormat | 1      |  5.664 μs |   3.329 μs | 0.1825 μs |  5.460 μs |  5.811 μs |     872 B |
| **CompositeFormat**    | **100**    | **45.660 μs** |  **44.521 μs** | **2.4404 μs** | **43.736 μs** | **48.406 μs** |   **14336 B** |
| StringFormat       | 100    | 38.168 μs | 114.376 μs | 6.2694 μs | 34.394 μs | 45.405 μs |   16736 B |
| InterpolatedFormat | 100    | 35.456 μs | 132.657 μs | 7.2714 μs | 31.198 μs | 43.852 μs |   14336 B |
