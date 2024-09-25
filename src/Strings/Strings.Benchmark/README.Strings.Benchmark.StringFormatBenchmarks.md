```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.435 μs** |  **12.933 μs** | **0.7089 μs** |  **5.920 μs** |  **7.244 μs** |     **872 B** |
| StringFormat       | 1      |  6.520 μs |   1.906 μs | 0.1045 μs |  6.436 μs |  6.637 μs |     896 B |
| InterpolatedFormat | 1      |  7.197 μs |  12.414 μs | 0.6804 μs |  6.713 μs |  7.974 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.870 μs** | **139.336 μs** | **7.6375 μs** | **33.252 μs** | **46.686 μs** |   **14336 B** |
| StringFormat       | 100    | 70.180 μs | 181.275 μs | 9.9363 μs | 64.269 μs | 81.652 μs |   16736 B |
| InterpolatedFormat | 100    | 35.893 μs | 123.421 μs | 6.7651 μs | 31.589 μs | 43.691 μs |   14336 B |
