```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.092 μs** |   **3.228 μs** | **0.1769 μs** |  **5.932 μs** |  **6.282 μs** |     **872 B** |
| StringFormat       | 1      |  6.740 μs |  11.365 μs | 0.6229 μs |  6.032 μs |  7.204 μs |     896 B |
| InterpolatedFormat | 1      |  5.881 μs |   1.308 μs | 0.0717 μs |  5.801 μs |  5.940 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.873 μs** | **116.310 μs** | **6.3753 μs** | **31.970 μs** | **43.230 μs** |   **14336 B** |
| StringFormat       | 100    | 37.973 μs | 137.723 μs | 7.5490 μs | 33.382 μs | 46.686 μs |   16736 B |
| InterpolatedFormat | 100    | 44.112 μs |  33.761 μs | 1.8506 μs | 42.358 μs | 46.047 μs |   14336 B |
