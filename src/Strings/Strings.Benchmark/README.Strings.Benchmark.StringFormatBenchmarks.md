```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.709 μs** |   **1.838 μs** |  **0.1007 μs** |  **6.632 μs** |  **6.823 μs** |     **872 B** |
| StringFormat       | 1      |  9.833 μs |  63.612 μs |  3.4868 μs |  7.715 μs | 13.857 μs |     896 B |
| InterpolatedFormat | 1      |  6.822 μs |  33.144 μs |  1.8167 μs |  5.570 μs |  8.906 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.935 μs** | **201.461 μs** | **11.0428 μs** | **33.508 μs** | **53.624 μs** |   **14336 B** |
| StringFormat       | 100    | 41.105 μs | 212.061 μs | 11.6238 μs | 34.380 μs | 54.528 μs |   16736 B |
| InterpolatedFormat | 100    | 37.136 μs | 150.596 μs |  8.2547 μs | 32.300 μs | 46.667 μs |   14336 B |
