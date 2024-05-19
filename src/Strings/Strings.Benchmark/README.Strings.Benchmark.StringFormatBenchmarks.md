```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max        | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.328 μs** |   **9.559 μs** |  **0.5240 μs** |  **6.030 μs** |  **6.021 μs** |   **6.933 μs** |     **872 B** |
| StringFormat       | 1      |  6.635 μs |   6.448 μs |  0.3534 μs |  6.552 μs |  6.331 μs |   7.023 μs |     896 B |
| InterpolatedFormat | 1      |  7.331 μs |  30.480 μs |  1.6707 μs |  6.733 μs |  6.041 μs |   9.218 μs |     872 B |
| **CompositeFormat**    | **100**    | **68.895 μs** | **779.375 μs** | **42.7202 μs** | **44.703 μs** | **43.761 μs** | **118.222 μs** |   **14336 B** |
| StringFormat       | 100    | 39.399 μs | 130.053 μs |  7.1287 μs | 35.562 μs | 35.011 μs |  47.624 μs |   16736 B |
| InterpolatedFormat | 100    | 44.457 μs | 112.118 μs |  6.1456 μs | 41.178 μs | 40.647 μs |  51.547 μs |   14336 B |
