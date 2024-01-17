```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.182 μs** |  **17.3133 μs** | **0.9490 μs** |  **5.505 μs** |  **7.267 μs** |     **872 B** |
| StringFormat       | 1      |  6.225 μs |   3.4538 μs | 0.1893 μs |  6.061 μs |  6.432 μs |     896 B |
| InterpolatedFormat | 1      |  5.830 μs |   0.9654 μs | 0.0529 μs |  5.790 μs |  5.891 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.026 μs** | **117.8966 μs** | **6.4623 μs** | **33.053 μs** | **44.483 μs** |   **14336 B** |
| StringFormat       | 100    | 39.050 μs | 166.5056 μs | 9.1267 μs | 33.503 μs | 49.584 μs |   16736 B |
| InterpolatedFormat | 100    | 34.440 μs | 128.4291 μs | 7.0396 μs | 30.376 μs | 42.569 μs |   14336 B |
