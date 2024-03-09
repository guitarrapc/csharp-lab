```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.951 μs** |   **4.500 μs** | **0.2466 μs** |  **6.784 μs** |  **7.234 μs** |     **872 B** |
| StringFormat       | 1      |  6.365 μs |   1.845 μs | 0.1011 μs |  6.271 μs |  6.472 μs |     896 B |
| InterpolatedFormat | 1      |  6.682 μs |   5.583 μs | 0.3060 μs |  6.471 μs |  7.033 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.073 μs** | **122.254 μs** | **6.7012 μs** | **32.159 μs** | **43.811 μs** |   **14336 B** |
| StringFormat       | 100    | 37.895 μs | 129.259 μs | 7.0851 μs | 33.473 μs | 46.067 μs |   16736 B |
| InterpolatedFormat | 100    | 33.933 μs | 125.578 μs | 6.8833 μs | 29.775 μs | 41.878 μs |   14336 B |
