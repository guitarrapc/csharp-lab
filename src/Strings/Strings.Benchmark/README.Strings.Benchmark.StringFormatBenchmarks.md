```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.126 μs** |   **1.107 μs** |  **0.0607 μs** |  **6.073 μs** |  **6.192 μs** |     **872 B** |
| StringFormat       | 1      |  7.647 μs |   6.935 μs |  0.3801 μs |  7.403 μs |  8.085 μs |     896 B |
| InterpolatedFormat | 1      |  6.652 μs |   2.586 μs |  0.1418 μs |  6.492 μs |  6.762 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.479 μs** | **292.688 μs** | **16.0432 μs** | **33.016 μs** | **64.565 μs** |   **14336 B** |
| StringFormat       | 100    | 48.849 μs |  37.229 μs |  2.0407 μs | 46.621 μs | 50.629 μs |   16736 B |
| InterpolatedFormat | 100    | 34.814 μs | 136.124 μs |  7.4614 μs | 30.496 μs | 43.430 μs |   14336 B |
