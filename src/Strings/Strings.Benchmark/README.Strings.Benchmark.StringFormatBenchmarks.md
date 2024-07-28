```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.677 μs** |   **3.8386 μs** |  **0.2104 μs** |  **6.603 μs** |  **6.513 μs** |  **6.914 μs** |     **872 B** |
| StringFormat       | 1      |  6.195 μs |   2.3244 μs |  0.1274 μs |  6.131 μs |  6.112 μs |  6.341 μs |     896 B |
| InterpolatedFormat | 1      |  5.951 μs |   0.8460 μs |  0.0464 μs |  5.941 μs |  5.911 μs |  6.002 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.702 μs** | **199.3525 μs** | **10.9272 μs** | **43.680 μs** | **43.110 μs** | **62.315 μs** |   **14336 B** |
| StringFormat       | 100    | 45.171 μs | 380.2738 μs | 20.8441 μs | 33.162 μs | 33.112 μs | 69.240 μs |   16736 B |
| InterpolatedFormat | 100    | 43.266 μs | 237.9201 μs | 13.0412 μs | 42.614 μs | 30.562 μs | 56.620 μs |   14336 B |
