```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.248 μs** |   **1.048 μs** |  **0.0574 μs** |  **6.281 μs** |  **6.182 μs** |  **6.282 μs** |     **872 B** |
| StringFormat       | 1      | 12.798 μs | 170.656 μs |  9.3542 μs |  7.654 μs |  7.144 μs | 23.595 μs |     896 B |
| InterpolatedFormat | 1      |  7.738 μs |  30.026 μs |  1.6458 μs |  6.823 μs |  6.753 μs |  9.638 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.519 μs** | **129.917 μs** |  **7.1212 μs** | **33.458 μs** | **33.358 μs** | **45.742 μs** |   **14336 B** |
| StringFormat       | 100    | 40.305 μs | 190.283 μs | 10.4301 μs | 34.434 μs | 34.133 μs | 52.347 μs |   16736 B |
| InterpolatedFormat | 100    | 46.390 μs |  25.964 μs |  1.4232 μs | 45.666 μs | 45.474 μs | 48.029 μs |   14336 B |
