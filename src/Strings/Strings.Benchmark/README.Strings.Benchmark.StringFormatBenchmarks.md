```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.881 μs** |   **2.9281 μs** |  **0.1605 μs** |  **5.881 μs** |  **5.720 μs** |  **6.041 μs** |     **872 B** |
| StringFormat       | 1      |  6.435 μs |   0.2107 μs |  0.0115 μs |  6.441 μs |  6.421 μs |  6.441 μs |     896 B |
| InterpolatedFormat | 1      |  5.918 μs |   1.3448 μs |  0.0737 μs |  5.891 μs |  5.861 μs |  6.001 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.638 μs** | **199.0022 μs** | **10.9080 μs** | **44.664 μs** | **44.022 μs** | **63.228 μs** |   **14336 B** |
| StringFormat       | 100    | 45.144 μs | 344.4690 μs | 18.8815 μs | 34.464 μs | 34.023 μs | 66.945 μs |   16736 B |
| InterpolatedFormat | 100    | 47.666 μs | 232.9162 μs | 12.7669 μs | 40.466 μs | 40.126 μs | 62.407 μs |   14336 B |
