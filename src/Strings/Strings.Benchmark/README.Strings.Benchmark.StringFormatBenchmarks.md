```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.141 μs** |   **0.7952 μs** |  **0.0436 μs** |  **6.111 μs** |  **6.191 μs** |     **872 B** |
| StringFormat       | 1      |  6.957 μs |  21.0819 μs |  1.1556 μs |  6.192 μs |  8.286 μs |     896 B |
| InterpolatedFormat | 1      |  6.685 μs |   2.4187 μs |  0.1326 μs |  6.541 μs |  6.802 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.619 μs** | **184.6257 μs** | **10.1200 μs** | **32.681 μs** | **50.304 μs** |   **14336 B** |
| StringFormat       | 100    | 51.550 μs | 219.6512 μs | 12.0398 μs | 44.564 μs | 65.452 μs |   16736 B |
| InterpolatedFormat | 100    | 36.574 μs | 170.0030 μs |  9.3184 μs | 31.183 μs | 47.334 μs |   14336 B |
