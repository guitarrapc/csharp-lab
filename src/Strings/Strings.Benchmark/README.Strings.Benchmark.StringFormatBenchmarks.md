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
| **CompositeFormat**    | **1**      |  **6.724 μs** |   **4.321 μs** | **0.2369 μs** |  **6.457 μs** |  **6.908 μs** |     **872 B** |
| StringFormat       | 1      |  6.186 μs |   2.219 μs | 0.1217 μs |  6.106 μs |  6.327 μs |     896 B |
| InterpolatedFormat | 1      |  6.269 μs |   5.662 μs | 0.3103 μs |  5.931 μs |  6.543 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.055 μs** | **132.917 μs** | **7.2856 μs** | **33.153 μs** | **46.427 μs** |   **14336 B** |
| StringFormat       | 100    | 39.659 μs | 180.172 μs | 9.8758 μs | 33.571 μs | 51.054 μs |   16736 B |
| InterpolatedFormat | 100    | 36.531 μs | 162.811 μs | 8.9242 μs | 31.008 μs | 46.827 μs |   14336 B |
