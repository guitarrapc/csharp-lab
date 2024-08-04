```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.125 μs** |   **7.221 μs** |  **0.3958 μs** |  **5.791 μs** |  **6.562 μs** |     **872 B** |
| StringFormat       | 1      |  7.219 μs |   5.875 μs |  0.3220 μs |  6.852 μs |  7.453 μs |     896 B |
| InterpolatedFormat | 1      |  5.550 μs |   2.539 μs |  0.1392 μs |  5.460 μs |  5.710 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.151 μs** | **200.184 μs** | **10.9728 μs** | **42.745 μs** | **61.821 μs** |   **14336 B** |
| StringFormat       | 100    | 52.055 μs | 249.063 μs | 13.6520 μs | 44.023 μs | 67.818 μs |   16736 B |
| InterpolatedFormat | 100    | 48.924 μs | 239.452 μs | 13.1252 μs | 41.337 μs | 64.080 μs |   14336 B |
