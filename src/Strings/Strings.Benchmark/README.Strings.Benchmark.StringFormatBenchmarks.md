```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.295 μs** |  **16.788 μs** |  **0.9202 μs** |  **5.681 μs** |  **7.353 μs** |     **872 B** |
| StringFormat       | 1      |  6.319 μs |   2.735 μs |  0.1499 μs |  6.152 μs |  6.442 μs |     896 B |
| InterpolatedFormat | 1      |  6.227 μs |   5.128 μs |  0.2811 μs |  5.957 μs |  6.518 μs |     872 B |
| **CompositeFormat**    | **100**    | **39.551 μs** | **217.230 μs** | **11.9071 μs** | **32.621 μs** | **53.300 μs** |   **14336 B** |
| StringFormat       | 100    | 37.863 μs | 153.558 μs |  8.4170 μs | 32.751 μs | 47.578 μs |   16736 B |
| InterpolatedFormat | 100    | 34.370 μs | 116.153 μs |  6.3668 μs | 30.186 μs | 41.697 μs |   14336 B |
