```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.112 μs** |   **1.632 μs** |  **0.0894 μs** |  **6.042 μs** |  **6.213 μs** |     **872 B** |
| StringFormat       | 1      |  7.104 μs |   5.529 μs |  0.3031 μs |  6.863 μs |  7.444 μs |     896 B |
| InterpolatedFormat | 1      |  6.112 μs |   6.962 μs |  0.3816 μs |  5.892 μs |  6.553 μs |     872 B |
| **CompositeFormat**    | **100**    | **39.662 μs** | **217.620 μs** | **11.9285 μs** | **32.472 μs** | **53.431 μs** |   **14336 B** |
| StringFormat       | 100    | 38.997 μs | 164.729 μs |  9.0293 μs | 33.695 μs | 49.423 μs |   16736 B |
| InterpolatedFormat | 100    | 36.567 μs | 139.380 μs |  7.6399 μs | 31.454 μs | 45.349 μs |   14336 B |
