```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.929 μs** |   **1.836 μs** | **0.1007 μs** |  **5.822 μs** |  **6.022 μs** |     **872 B** |
| StringFormat       | 1      |  7.286 μs |   1.800 μs | 0.0987 μs |  7.173 μs |  7.353 μs |     896 B |
| InterpolatedFormat | 1      |  5.718 μs |   4.459 μs | 0.2444 μs |  5.451 μs |  5.931 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.423 μs** | **122.049 μs** | **6.6899 μs** | **32.486 μs** | **44.148 μs** |   **14336 B** |
| StringFormat       | 100    | 37.821 μs | 167.312 μs | 9.1709 μs | 32.511 μs | 48.411 μs |   16736 B |
| InterpolatedFormat | 100    | 42.230 μs |   1.425 μs | 0.0781 μs | 42.180 μs | 42.320 μs |   14336 B |
