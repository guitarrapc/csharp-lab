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
| **CompositeFormat**    | **1**      |  **5.923 μs** |   **3.828 μs** |  **0.2098 μs** |  **5.760 μs** |  **6.160 μs** |     **872 B** |
| StringFormat       | 1      |  6.719 μs |  12.877 μs |  0.7058 μs |  6.311 μs |  7.534 μs |     896 B |
| InterpolatedFormat | 1      |  6.585 μs |   2.026 μs |  0.1111 μs |  6.481 μs |  6.702 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.652 μs** | **144.985 μs** |  **7.9471 μs** | **31.889 μs** | **45.826 μs** |   **14336 B** |
| StringFormat       | 100    | 54.500 μs | 296.608 μs | 16.2581 μs | 44.745 μs | 73.268 μs |   16736 B |
| InterpolatedFormat | 100    | 41.135 μs |  20.041 μs |  1.0985 μs | 40.321 μs | 42.385 μs |   14336 B |
