```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.141 μs** |   **0.7390 μs** |  **0.0405 μs** |  **6.140 μs** |  **6.101 μs** |  **6.182 μs** |     **872 B** |
| StringFormat       | 1      |  6.425 μs |   0.9279 μs |  0.0509 μs |  6.432 μs |  6.371 μs |  6.472 μs |     896 B |
| InterpolatedFormat | 1      |  5.861 μs |   1.9047 μs |  0.1044 μs |  5.911 μs |  5.741 μs |  5.931 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.213 μs** | **321.4403 μs** | **17.6192 μs** | **33.131 μs** | **32.951 μs** | **63.558 μs** |   **14336 B** |
| StringFormat       | 100    | 51.414 μs | 197.0271 μs | 10.7997 μs | 45.270 μs | 45.088 μs | 63.884 μs |   16736 B |
| InterpolatedFormat | 100    | 35.402 μs | 136.4929 μs |  7.4816 μs | 31.108 μs | 31.057 μs | 44.041 μs |   14336 B |
