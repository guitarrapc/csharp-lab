```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.027 μs** |   **4.804 μs** | **0.2633 μs** |  **5.730 μs** |  **6.231 μs** |     **872 B** |
| StringFormat       | 1      |  7.250 μs |   2.595 μs | 0.1422 μs |  7.153 μs |  7.413 μs |     896 B |
| InterpolatedFormat | 1      |  6.428 μs |   5.701 μs | 0.3125 μs |  6.237 μs |  6.788 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.398 μs** | **158.561 μs** | **8.6913 μs** | **32.295 μs** | **47.434 μs** |   **14336 B** |
| StringFormat       | 100    | 37.867 μs | 148.369 μs | 8.1326 μs | 33.072 μs | 47.257 μs |   16736 B |
| InterpolatedFormat | 100    | 42.350 μs |  47.025 μs | 2.5776 μs | 40.506 μs | 45.295 μs |   14336 B |
