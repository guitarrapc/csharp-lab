```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.842 μs** |   **4.5813 μs** |  **0.2511 μs** |  **5.581 μs** |  **6.082 μs** |     **872 B** |
| StringFormat       | 1      |  6.169 μs |   0.8234 μs |  0.0451 μs |  6.122 μs |  6.212 μs |     896 B |
| InterpolatedFormat | 1      |  6.976 μs |   1.7337 μs |  0.0950 μs |  6.883 μs |  7.072 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.845 μs** | **231.1617 μs** | **12.6708 μs** | **42.455 μs** | **64.475 μs** |   **14336 B** |
| StringFormat       | 100    | 49.042 μs |   6.4941 μs |  0.3560 μs | 48.631 μs | 49.262 μs |   16736 B |
| InterpolatedFormat | 100    | 38.224 μs | 239.9135 μs | 13.1505 μs | 30.567 μs | 53.409 μs |   14336 B |
