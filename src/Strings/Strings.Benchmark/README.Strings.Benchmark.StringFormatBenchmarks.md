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
| **CompositeFormat**    | **1**      |  **5.949 μs** |   **3.558 μs** |  **0.1950 μs** |  **5.752 μs** |  **6.142 μs** |     **872 B** |
| StringFormat       | 1      |  7.035 μs |   4.455 μs |  0.2442 μs |  6.838 μs |  7.309 μs |     896 B |
| InterpolatedFormat | 1      |  6.722 μs |  29.294 μs |  1.6057 μs |  5.760 μs |  8.576 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.960 μs** | **133.767 μs** |  **7.3322 μs** | **33.622 μs** | **46.426 μs** |   **14336 B** |
| StringFormat       | 100    | 73.260 μs | 199.283 μs | 10.9234 μs | 66.735 μs | 85.871 μs |   16736 B |
| InterpolatedFormat | 100    | 36.088 μs | 155.508 μs |  8.5239 μs | 30.919 μs | 45.926 μs |   14336 B |
