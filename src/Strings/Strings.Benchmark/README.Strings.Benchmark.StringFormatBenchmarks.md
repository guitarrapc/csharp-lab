```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.914 μs** |   **5.120 μs** |  **0.2806 μs** |  **5.699 μs** |  **6.231 μs** |     **872 B** |
| StringFormat       | 1      |  6.290 μs |   2.383 μs |  0.1306 μs |  6.156 μs |  6.417 μs |     896 B |
| InterpolatedFormat | 1      |  6.574 μs |   2.272 μs |  0.1245 μs |  6.497 μs |  6.718 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.728 μs** | **305.619 μs** | **16.7520 μs** | **33.688 μs** | **64.004 μs** |   **14336 B** |
| StringFormat       | 100    | 42.763 μs | 196.565 μs | 10.7744 μs | 34.474 μs | 54.943 μs |   16736 B |
| InterpolatedFormat | 100    | 39.650 μs | 126.875 μs |  6.9545 μs | 31.779 μs | 44.963 μs |   14336 B |
