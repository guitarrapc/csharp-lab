```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.564 μs** |   **3.696 μs** |  **0.2026 μs** |  **6.338 μs** |  **6.728 μs** |     **872 B** |
| StringFormat       | 1      |  7.063 μs |  11.837 μs |  0.6488 μs |  6.382 μs |  7.674 μs |     896 B |
| InterpolatedFormat | 1      |  5.428 μs |   3.188 μs |  0.1747 μs |  5.281 μs |  5.621 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.960 μs** | **149.476 μs** |  **8.1933 μs** | **32.185 μs** | **46.421 μs** |   **14336 B** |
| StringFormat       | 100    | 46.362 μs | 260.700 μs | 14.2899 μs | 31.678 μs | 60.222 μs |   16736 B |
| InterpolatedFormat | 100    | 49.274 μs | 225.305 μs | 12.3497 μs | 42.033 μs | 63.533 μs |   14336 B |
