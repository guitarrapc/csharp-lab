```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.426 μs** |  **17.878 μs** |  **0.9799 μs** |  **6.243 μs** |  **5.551 μs** |  **7.485 μs** |     **872 B** |
| StringFormat       | 1      |  5.731 μs |   2.696 μs |  0.1478 μs |  5.801 μs |  5.561 μs |  5.832 μs |     896 B |
| InterpolatedFormat | 1      |  5.614 μs |   6.662 μs |  0.3652 μs |  5.710 μs |  5.210 μs |  5.921 μs |     584 B |
| **CompositeFormat**    | **100**    | **40.038 μs** | **431.804 μs** | **23.6686 μs** | **26.835 μs** | **25.915 μs** | **67.362 μs** |   **14336 B** |
| StringFormat       | 100    | 33.418 μs | 171.129 μs |  9.3802 μs | 28.128 μs | 27.878 μs | 44.248 μs |   16736 B |
| InterpolatedFormat | 100    | 42.954 μs | 233.844 μs | 12.8178 μs | 36.979 μs | 34.214 μs | 57.668 μs |   14336 B |
