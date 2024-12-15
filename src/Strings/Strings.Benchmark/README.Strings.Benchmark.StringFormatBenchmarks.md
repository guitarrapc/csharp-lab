```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.116 μs** |   **0.6425 μs** |  **0.0352 μs** |  **6.075 μs** |  **6.136 μs** |     **872 B** |
| StringFormat       | 1      |  6.285 μs |   3.4538 μs |  0.1893 μs |  6.121 μs |  6.492 μs |     896 B |
| InterpolatedFormat | 1      |  5.724 μs |   0.8227 μs |  0.0451 μs |  5.681 μs |  5.771 μs |     872 B |
| **CompositeFormat**    | **100**    | **39.788 μs** | **214.6190 μs** | **11.7640 μs** | **32.801 μs** | **53.370 μs** |   **14336 B** |
| StringFormat       | 100    | 37.443 μs | 123.1143 μs |  6.7483 μs | 33.442 μs | 45.234 μs |   16736 B |
| InterpolatedFormat | 100    | 48.506 μs | 211.3615 μs | 11.5854 μs | 41.787 μs | 61.884 μs |   14336 B |
