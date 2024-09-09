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
| **CompositeFormat**    | **1**      |  **6.005 μs** |   **1.530 μs** |  **0.0839 μs** |  **5.952 μs** |  **6.101 μs** |     **872 B** |
| StringFormat       | 1      |  6.252 μs |   2.114 μs |  0.1159 μs |  6.162 μs |  6.383 μs |     896 B |
| InterpolatedFormat | 1      |  5.738 μs |   2.210 μs |  0.1211 μs |  5.601 μs |  5.831 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.301 μs** | **263.194 μs** | **14.4265 μs** | **43.961 μs** | **68.959 μs** |   **14336 B** |
| StringFormat       | 100    | 52.624 μs | 245.310 μs | 13.4463 μs | 44.542 μs | 68.146 μs |   16736 B |
| InterpolatedFormat | 100    | 40.719 μs | 153.773 μs |  8.4288 μs | 31.218 μs | 47.298 μs |   14336 B |
