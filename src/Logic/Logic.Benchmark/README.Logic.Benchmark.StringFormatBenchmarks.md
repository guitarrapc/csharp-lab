```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.045 μs** |   **4.7269 μs** |  **0.2591 μs** |  **6.095 μs** |  **5.765 μs** |  **6.276 μs** |     **872 B** |
| StringFormat       | 1      |  7.497 μs |   0.6407 μs |  0.0351 μs |  7.494 μs |  7.464 μs |  7.534 μs |     896 B |
| InterpolatedFormat | 1      |  5.578 μs |   1.9613 μs |  0.1075 μs |  5.521 μs |  5.511 μs |  5.702 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.942 μs** | **576.6426 μs** | **31.6077 μs** | **34.971 μs** | **32.446 μs** | **88.410 μs** |   **14336 B** |
| StringFormat       | 100    | 52.812 μs | 214.1351 μs | 11.7375 μs | 46.196 μs | 45.876 μs | 66.364 μs |   16736 B |
| InterpolatedFormat | 100    | 43.686 μs |  49.7025 μs |  2.7244 μs | 42.691 μs | 41.599 μs | 46.768 μs |   14336 B |
