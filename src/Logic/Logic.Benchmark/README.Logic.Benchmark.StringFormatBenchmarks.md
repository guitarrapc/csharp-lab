```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.861 μs** |   **3.389 μs** | **0.1858 μs** |  **5.650 μs** |  **6.001 μs** |     **872 B** |
| StringFormat       | 1      |  7.137 μs |   2.324 μs | 0.1274 μs |  7.053 μs |  7.284 μs |     896 B |
| InterpolatedFormat | 1      |  5.865 μs |   2.936 μs | 0.1609 μs |  5.711 μs |  6.032 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.916 μs** | **119.199 μs** | **6.5337 μs** | **32.108 μs** | **43.460 μs** |   **14336 B** |
| StringFormat       | 100    | 37.535 μs | 132.108 μs | 7.2413 μs | 33.087 μs | 45.891 μs |   16736 B |
| InterpolatedFormat | 100    | 36.244 μs | 150.500 μs | 8.2494 μs | 31.228 μs | 45.765 μs |   14336 B |
