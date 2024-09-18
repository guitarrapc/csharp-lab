```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.077 μs** |   **1.7056 μs** |  **0.0935 μs** |  **5.970 μs** |  **6.141 μs** |     **872 B** |
| StringFormat       | 1      |  7.221 μs |   5.0388 μs |  0.2762 μs |  7.038 μs |  7.539 μs |     896 B |
| InterpolatedFormat | 1      |  5.805 μs |   0.8381 μs |  0.0459 μs |  5.755 μs |  5.845 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.584 μs** | **228.8307 μs** | **12.5430 μs** | **44.307 μs** | **66.067 μs** |   **14336 B** |
| StringFormat       | 100    | 38.741 μs | 157.5047 μs |  8.6334 μs | 33.692 μs | 48.710 μs |   16736 B |
| InterpolatedFormat | 100    | 35.052 μs | 120.5304 μs |  6.6067 μs | 31.128 μs | 42.680 μs |   14336 B |
