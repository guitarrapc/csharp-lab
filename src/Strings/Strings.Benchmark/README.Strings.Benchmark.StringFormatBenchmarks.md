```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.499 μs** |   **8.0508 μs** |  **0.4413 μs** |  **6.312 μs** |  **6.182 μs** |  **7.003 μs** |     **872 B** |
| StringFormat       | 1      |  6.419 μs |   1.4728 μs |  0.0807 μs |  6.412 μs |  6.342 μs |  6.503 μs |     896 B |
| InterpolatedFormat | 1      |  5.966 μs |   0.3649 μs |  0.0200 μs |  5.966 μs |  5.947 μs |  5.987 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.439 μs** | **335.9803 μs** | **18.4162 μs** | **34.073 μs** | **33.542 μs** | **65.702 μs** |   **14336 B** |
| StringFormat       | 100    | 38.977 μs | 126.4190 μs |  6.9295 μs | 35.477 μs | 34.495 μs | 46.958 μs |   16736 B |
| InterpolatedFormat | 100    | 50.183 μs | 214.8481 μs | 11.7765 μs | 43.621 μs | 43.150 μs | 63.779 μs |   14336 B |
