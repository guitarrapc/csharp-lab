```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.223 μs** |   **1.971 μs** |  **0.1080 μs** |  **6.252 μs** |  **6.103 μs** |  **6.313 μs** |     **872 B** |
| StringFormat       | 1      |  8.088 μs |  10.580 μs |  0.5799 μs |  7.974 μs |  7.573 μs |  8.716 μs |     896 B |
| InterpolatedFormat | 1      |  5.804 μs |   2.335 μs |  0.1280 μs |  5.740 μs |  5.721 μs |  5.952 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.832 μs** | **146.895 μs** |  **8.0518 μs** | **33.223 μs** | **33.143 μs** | **47.129 μs** |   **14336 B** |
| StringFormat       | 100    | 37.287 μs | 129.565 μs |  7.1019 μs | 33.352 μs | 33.023 μs | 45.485 μs |   16736 B |
| InterpolatedFormat | 100    | 41.944 μs | 324.572 μs | 17.7909 μs | 31.889 μs | 31.458 μs | 62.486 μs |   14336 B |
