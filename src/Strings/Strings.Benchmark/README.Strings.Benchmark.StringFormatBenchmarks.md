```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.447 μs** |   **0.1159 μs** |  **0.0064 μs** |  **5.440 μs** |  **5.451 μs** |     **872 B** |
| StringFormat       | 1      |  6.008 μs |   2.1765 μs |  0.1193 μs |  5.871 μs |  6.091 μs |     896 B |
| InterpolatedFormat | 1      |  5.357 μs |   4.9889 μs |  0.2735 μs |  5.110 μs |  5.651 μs |     584 B |
| **CompositeFormat**    | **100**    | **40.047 μs** | **133.4957 μs** |  **7.3174 μs** | **35.535 μs** | **48.490 μs** |   **14336 B** |
| StringFormat       | 100    | 45.107 μs | 232.1071 μs | 12.7226 μs | 37.168 μs | 59.781 μs |   16736 B |
| InterpolatedFormat | 100    | 39.806 μs |  41.2502 μs |  2.2611 μs | 37.594 μs | 42.114 μs |   14336 B |
