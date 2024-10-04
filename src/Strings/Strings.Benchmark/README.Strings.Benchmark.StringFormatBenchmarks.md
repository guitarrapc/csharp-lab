```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.159 μs** |   **1.772 μs** | **0.0971 μs** |  **6.052 μs** |  **6.242 μs** |     **872 B** |
| StringFormat       | 1      |  7.361 μs |   3.882 μs | 0.2128 μs |  7.214 μs |  7.605 μs |     896 B |
| InterpolatedFormat | 1      |  6.015 μs |   1.053 μs | 0.0577 μs |  5.982 μs |  6.082 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.554 μs** |  **79.335 μs** | **4.3486 μs** | **44.503 μs** | **53.149 μs** |   **14336 B** |
| StringFormat       | 100    | 38.026 μs | 120.156 μs | 6.5862 μs | 33.868 μs | 45.620 μs |   16736 B |
| InterpolatedFormat | 100    | 36.926 μs | 125.931 μs | 6.9027 μs | 31.529 μs | 44.704 μs |   14336 B |
