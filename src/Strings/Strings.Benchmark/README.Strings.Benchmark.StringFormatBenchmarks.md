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
| **CompositeFormat**    | **1**      |  **6.252 μs** |   **1.834 μs** |  **0.1005 μs** |  **6.152 μs** |  **6.353 μs** |     **872 B** |
| StringFormat       | 1      |  6.633 μs |  10.985 μs |  0.6021 μs |  6.172 μs |  7.314 μs |     896 B |
| InterpolatedFormat | 1      |  6.325 μs |   7.327 μs |  0.4016 μs |  5.871 μs |  6.633 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.526 μs** | **242.842 μs** | **13.3110 μs** | **43.652 μs** | **66.895 μs** |   **14336 B** |
| StringFormat       | 100    | 52.404 μs | 244.611 μs | 13.4080 μs | 44.182 μs | 67.876 μs |   16736 B |
| InterpolatedFormat | 100    | 34.419 μs | 126.328 μs |  6.9245 μs | 30.331 μs | 42.414 μs |   14336 B |
