```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.076 μs** |   **0.9104 μs** | **0.0499 μs** |  **6.042 μs** |  **6.133 μs** |     **872 B** |
| StringFormat       | 1      |  6.378 μs |   1.2147 μs | 0.0666 μs |  6.321 μs |  6.451 μs |     896 B |
| InterpolatedFormat | 1      |  6.680 μs |   0.7373 μs | 0.0404 μs |  6.643 μs |  6.723 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.200 μs** |  **29.4362 μs** | **1.6135 μs** | **43.141 μs** | **46.057 μs** |   **14336 B** |
| StringFormat       | 100    | 37.170 μs | 127.0238 μs | 6.9626 μs | 32.922 μs | 45.205 μs |   16736 B |
| InterpolatedFormat | 100    | 34.196 μs | 137.8141 μs | 7.5541 μs | 29.825 μs | 42.919 μs |   14336 B |
