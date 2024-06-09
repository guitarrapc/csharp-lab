```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.938 μs** |   **4.290 μs** |  **0.2351 μs** |  **5.992 μs** |  **5.681 μs** |  **6.142 μs** |     **872 B** |
| StringFormat       | 1      |  6.909 μs |  11.536 μs |  0.6324 μs |  7.153 μs |  6.191 μs |  7.383 μs |     896 B |
| InterpolatedFormat | 1      |  6.584 μs |   3.424 μs |  0.1877 μs |  6.688 μs |  6.367 μs |  6.697 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.056 μs** | **341.246 μs** | **18.7049 μs** | **33.422 μs** | **33.092 μs** | **65.653 μs** |   **14336 B** |
| StringFormat       | 100    | 52.288 μs | 224.618 μs | 12.3120 μs | 45.215 μs | 45.145 μs | 66.505 μs |   16736 B |
| InterpolatedFormat | 100    | 37.330 μs | 203.475 μs | 11.1532 μs | 31.178 μs | 30.608 μs | 50.205 μs |   14336 B |
