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
| **CompositeFormat**    | **1**      |  **5.988 μs** |   **1.956 μs** |  **0.1072 μs** |  **5.921 μs** |  **6.112 μs** |     **872 B** |
| StringFormat       | 1      |  6.596 μs |   8.595 μs |  0.4711 μs |  6.131 μs |  7.074 μs |     896 B |
| InterpolatedFormat | 1      |  5.858 μs |   2.277 μs |  0.1248 μs |  5.781 μs |  6.002 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.949 μs** | **149.893 μs** |  **8.2161 μs** | **33.007 μs** | **47.434 μs** |   **14336 B** |
| StringFormat       | 100    | 74.518 μs | 231.091 μs | 12.6669 μs | 66.303 μs | 89.106 μs |   16736 B |
| InterpolatedFormat | 100    | 38.074 μs | 163.363 μs |  8.9545 μs | 32.450 μs | 48.400 μs |   14336 B |
