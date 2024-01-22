```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.372 μs** |   **8.226 μs** |  **0.4509 μs** |  **6.112 μs** |  **6.893 μs** |     **872 B** |
| StringFormat       | 1      |  6.101 μs |   3.743 μs |  0.2052 μs |  5.902 μs |  6.311 μs |     896 B |
| InterpolatedFormat | 1      |  6.430 μs |   5.906 μs |  0.3237 μs |  6.157 μs |  6.787 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.143 μs** | **120.098 μs** |  **6.5830 μs** | **33.253 μs** | **44.744 μs** |   **14336 B** |
| StringFormat       | 100    | 37.236 μs | 142.851 μs |  7.8302 μs | 32.590 μs | 46.276 μs |   16736 B |
| InterpolatedFormat | 100    | 48.184 μs | 231.712 μs | 12.7009 μs | 40.657 μs | 62.847 μs |   14336 B |
