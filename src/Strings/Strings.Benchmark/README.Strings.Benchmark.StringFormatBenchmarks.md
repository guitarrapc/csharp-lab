```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.124 μs** |   **1.187 μs** |  **0.0651 μs** |  **6.121 μs** |  **6.061 μs** |  **6.191 μs** |     **872 B** |
| StringFormat       | 1      |  6.346 μs |   2.140 μs |  0.1173 μs |  6.322 μs |  6.242 μs |  6.473 μs |     896 B |
| InterpolatedFormat | 1      |  5.597 μs |   6.667 μs |  0.3654 μs |  5.499 μs |  5.290 μs |  6.001 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.363 μs** | **152.235 μs** |  **8.3445 μs** | **32.651 μs** | **32.441 μs** | **46.998 μs** |   **14336 B** |
| StringFormat       | 100    | 47.104 μs | 391.551 μs | 21.4622 μs | 35.015 μs | 34.413 μs | 71.884 μs |   16736 B |
| InterpolatedFormat | 100    | 37.496 μs | 166.893 μs |  9.1480 μs | 32.269 μs | 32.160 μs | 48.059 μs |   14336 B |
