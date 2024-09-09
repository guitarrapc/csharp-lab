```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.004 μs** |   **1.385 μs** |  **0.0759 μs** |  **5.951 μs** |  **6.091 μs** |     **872 B** |
| StringFormat       | 1      |  6.315 μs |   2.356 μs |  0.1292 μs |  6.221 μs |  6.463 μs |     896 B |
| InterpolatedFormat | 1      |  6.146 μs |   3.489 μs |  0.1913 μs |  5.965 μs |  6.346 μs |     872 B |
| **CompositeFormat**    | **100**    | **68.385 μs** | **210.189 μs** | **11.5212 μs** | **59.638 μs** | **81.439 μs** |   **14336 B** |
| StringFormat       | 100    | 38.123 μs | 134.227 μs |  7.3574 μs | 33.589 μs | 46.612 μs |   16736 B |
| InterpolatedFormat | 100    | 35.367 μs | 149.280 μs |  8.1826 μs | 30.568 μs | 44.815 μs |   14336 B |
