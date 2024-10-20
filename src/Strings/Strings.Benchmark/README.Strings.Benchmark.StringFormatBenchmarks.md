```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.330 μs** |   **5.968 μs** |  **0.3271 μs** |  **6.016 μs** |  **6.668 μs** |     **872 B** |
| StringFormat       | 1      |  7.060 μs |   6.157 μs |  0.3375 μs |  6.742 μs |  7.415 μs |     896 B |
| InterpolatedFormat | 1      |  7.250 μs |  10.616 μs |  0.5819 μs |  6.591 μs |  7.694 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.353 μs** |  **22.464 μs** |  **1.2313 μs** | **46.983 μs** | **49.368 μs** |   **14336 B** |
| StringFormat       | 100    | 70.356 μs | 199.519 μs | 10.9363 μs | 63.218 μs | 82.947 μs |   16736 B |
| InterpolatedFormat | 100    | 36.846 μs | 123.255 μs |  6.7560 μs | 32.441 μs | 44.624 μs |   14336 B |
