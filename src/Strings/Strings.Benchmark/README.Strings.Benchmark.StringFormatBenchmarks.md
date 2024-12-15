```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.922 μs** |   **3.807 μs** |  **0.2087 μs** |  **5.792 μs** |  **6.163 μs** |     **872 B** |
| StringFormat       | 1      |  7.086 μs |   2.051 μs |  0.1124 μs |  6.989 μs |  7.209 μs |     896 B |
| InterpolatedFormat | 1      |  5.794 μs |   1.541 μs |  0.0844 μs |  5.740 μs |  5.891 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.505 μs** | **253.918 μs** | **13.9181 μs** | **32.350 μs** | **56.576 μs** |   **14336 B** |
| StringFormat       | 100    | 48.664 μs |  27.534 μs |  1.5092 μs | 47.058 μs | 50.053 μs |   16736 B |
| InterpolatedFormat | 100    | 49.028 μs | 215.485 μs | 11.8114 μs | 42.199 μs | 62.667 μs |   14336 B |
