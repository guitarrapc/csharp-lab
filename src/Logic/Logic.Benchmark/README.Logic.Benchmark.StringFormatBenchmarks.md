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
| **CompositeFormat**    | **1**      |  **5.794 μs** |   **5.654 μs** |  **0.3099 μs** |  **5.521 μs** |  **6.131 μs** |     **872 B** |
| StringFormat       | 1      |  5.874 μs |   3.300 μs |  0.1809 μs |  5.700 μs |  6.061 μs |     896 B |
| InterpolatedFormat | 1      |  5.647 μs |   1.352 μs |  0.0741 μs |  5.590 μs |  5.731 μs |     872 B |
| **CompositeFormat**    | **100**    | **45.310 μs** |  **58.347 μs** |  **3.1982 μs** | **43.330 μs** | **49.000 μs** |   **14336 B** |
| StringFormat       | 100    | 50.406 μs | 211.537 μs | 11.5950 μs | 43.075 μs | 63.773 μs |   16736 B |
| InterpolatedFormat | 100    | 47.288 μs | 214.484 μs | 11.7566 μs | 40.486 μs | 60.864 μs |   14336 B |
