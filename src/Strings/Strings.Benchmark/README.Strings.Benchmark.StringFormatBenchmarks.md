```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max        | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.543 μs** |   **8.031 μs** |  **0.4402 μs** |  **6.473 μs** |  **6.142 μs** |   **7.014 μs** |     **872 B** |
| StringFormat       | 1      |  7.266 μs |  11.685 μs |  0.6405 μs |  7.504 μs |  6.541 μs |   7.754 μs |     896 B |
| InterpolatedFormat | 1      |  7.212 μs |  11.819 μs |  0.6479 μs |  7.269 μs |  6.537 μs |   7.830 μs |     872 B |
| **CompositeFormat**    | **100**    | **68.714 μs** | **753.897 μs** | **41.3236 μs** | **45.855 μs** | **43.871 μs** | **116.417 μs** |   **14336 B** |
| StringFormat       | 100    | 39.290 μs | 171.574 μs |  9.4045 μs | 34.644 μs | 33.112 μs |  50.113 μs |   16736 B |
| InterpolatedFormat | 100    | 37.000 μs | 203.256 μs | 11.1411 μs | 30.648 μs | 30.487 μs |  49.864 μs |   14336 B |
