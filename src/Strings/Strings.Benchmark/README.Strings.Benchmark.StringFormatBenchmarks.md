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
| **CompositeFormat**    | **1**      |  **6.132 μs** |   **3.379 μs** |  **0.1852 μs** |  **5.952 μs** |  **6.322 μs** |     **872 B** |
| StringFormat       | 1      |  6.201 μs |   3.344 μs |  0.1833 μs |  6.041 μs |  6.401 μs |     896 B |
| InterpolatedFormat | 1      |  6.005 μs |   9.505 μs |  0.5210 μs |  5.571 μs |  6.583 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.294 μs** | **123.247 μs** |  **6.7556 μs** | **31.373 μs** | **43.094 μs** |   **14336 B** |
| StringFormat       | 100    | 50.697 μs | 216.487 μs | 11.8664 μs | 43.751 μs | 64.399 μs |   16736 B |
| InterpolatedFormat | 100    | 50.073 μs | 249.500 μs | 13.6759 μs | 41.637 μs | 65.852 μs |   14336 B |
