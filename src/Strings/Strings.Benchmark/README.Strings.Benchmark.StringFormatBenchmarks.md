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
| **CompositeFormat**    | **1**      |  **6.863 μs** |   **0.6268 μs** |  **0.0344 μs** |  **6.824 μs** |  **6.883 μs** |     **872 B** |
| StringFormat       | 1      |  6.325 μs |   1.3042 μs |  0.0715 μs |  6.261 μs |  6.402 μs |     896 B |
| InterpolatedFormat | 1      |  6.356 μs |   5.2257 μs |  0.2864 μs |  6.042 μs |  6.603 μs |     872 B |
| **CompositeFormat**    | **100**    | **72.454 μs** | **222.7612 μs** | **12.2103 μs** | **58.655 μs** | **81.859 μs** |   **14336 B** |
| StringFormat       | 100    | 42.709 μs | 165.7828 μs |  9.0871 μs | 37.239 μs | 53.199 μs |   16736 B |
| InterpolatedFormat | 100    | 59.738 μs | 176.1651 μs |  9.6562 μs | 52.587 μs | 70.722 μs |   14336 B |
