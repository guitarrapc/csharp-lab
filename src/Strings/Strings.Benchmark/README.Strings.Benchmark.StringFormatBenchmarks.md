```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.310 μs** |   **1.492 μs** |  **0.0818 μs** |  **6.216 μs** |  **6.367 μs** |     **872 B** |
| StringFormat       | 1      |  6.117 μs |   2.946 μs |  0.1615 μs |  5.987 μs |  6.298 μs |     896 B |
| InterpolatedFormat | 1      |  6.450 μs |   4.081 μs |  0.2237 μs |  6.297 μs |  6.707 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.630 μs** | **116.369 μs** |  **6.3786 μs** | **31.700 μs** | **42.990 μs** |   **14336 B** |
| StringFormat       | 100    | 54.739 μs | 239.107 μs | 13.1063 μs | 44.464 μs | 69.499 μs |   16736 B |
| InterpolatedFormat | 100    | 34.143 μs | 120.645 μs |  6.6129 μs | 30.176 μs | 41.777 μs |   14336 B |
