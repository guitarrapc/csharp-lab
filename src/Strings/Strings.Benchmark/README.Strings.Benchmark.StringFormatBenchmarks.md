```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.025 μs** |   **0.8227 μs** |  **0.0451 μs** |  **5.982 μs** |  **6.072 μs** |     **872 B** |
| StringFormat       | 1      |  7.110 μs |   0.1053 μs |  0.0058 μs |  7.103 μs |  7.113 μs |     896 B |
| InterpolatedFormat | 1      |  5.892 μs |   6.8617 μs |  0.3761 μs |  5.521 μs |  6.273 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.727 μs** | **183.7891 μs** | **10.0741 μs** | **43.746 μs** | **61.358 μs** |   **14336 B** |
| StringFormat       | 100    | 44.236 μs | 187.7961 μs | 10.2937 μs | 33.362 μs | 53.831 μs |   16736 B |
| InterpolatedFormat | 100    | 35.664 μs | 119.8266 μs |  6.5681 μs | 31.683 μs | 43.245 μs |   14336 B |
