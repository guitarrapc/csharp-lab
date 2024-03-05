```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.602 μs** |   **8.616 μs** | **0.4723 μs** |  **6.272 μs** |  **7.143 μs** |     **872 B** |
| StringFormat       | 1      |  6.409 μs |   7.813 μs | 0.4282 μs |  6.052 μs |  6.884 μs |     896 B |
| InterpolatedFormat | 1      |  5.750 μs |   1.740 μs | 0.0954 μs |  5.650 μs |  5.840 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.184 μs** | **177.388 μs** | **9.7232 μs** | **31.170 μs** | **48.402 μs** |   **14336 B** |
| StringFormat       | 100    | 37.829 μs | 160.561 μs | 8.8009 μs | 32.712 μs | 47.991 μs |   16736 B |
| InterpolatedFormat | 100    | 41.825 μs |  41.971 μs | 2.3006 μs | 40.126 μs | 44.443 μs |   14336 B |
