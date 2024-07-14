```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.634 μs** |   **5.987 μs** |  **0.3282 μs** |  **5.330 μs** |  **5.981 μs** |     **872 B** |
| StringFormat       | 1      |  6.578 μs |  14.136 μs |  0.7749 μs |  6.121 μs |  7.473 μs |     896 B |
| InterpolatedFormat | 1      |  5.467 μs |   2.565 μs |  0.1406 μs |  5.330 μs |  5.611 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.469 μs** | **201.772 μs** | **11.0598 μs** | **42.044 μs** | **61.239 μs** |   **14336 B** |
| StringFormat       | 100    | 36.610 μs | 127.514 μs |  6.9895 μs | 32.406 μs | 44.678 μs |   16736 B |
| InterpolatedFormat | 100    | 50.591 μs |  26.683 μs |  1.4626 μs | 49.663 μs | 52.277 μs |   14336 B |
