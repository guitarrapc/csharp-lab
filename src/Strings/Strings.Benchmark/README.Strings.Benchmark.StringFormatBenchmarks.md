```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.098 μs** |   **7.350 μs** | **0.4029 μs** |  **5.841 μs** |  **6.562 μs** |     **872 B** |
| StringFormat       | 1      |  7.148 μs |   5.034 μs | 0.2760 μs |  6.964 μs |  7.465 μs |     896 B |
| InterpolatedFormat | 1      |  5.957 μs |   2.728 μs | 0.1495 μs |  5.871 μs |  6.130 μs |     872 B |
| **CompositeFormat**    | **100**    | **66.924 μs** | **117.450 μs** | **6.4378 μs** | **62.877 μs** | **74.348 μs** |   **14336 B** |
| StringFormat       | 100    | 41.147 μs | 147.663 μs | 8.0939 μs | 33.202 μs | 49.382 μs |   16736 B |
| InterpolatedFormat | 100    | 43.953 μs |  45.810 μs | 2.5110 μs | 42.190 μs | 46.828 μs |   14336 B |
