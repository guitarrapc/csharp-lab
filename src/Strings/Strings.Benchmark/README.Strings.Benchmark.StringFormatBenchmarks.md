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
| **CompositeFormat**    | **1**      |  **6.780 μs** |   **1.838 μs** | **0.1007 μs** |  **6.673 μs** |  **6.873 μs** |     **872 B** |
| StringFormat       | 1      |  7.463 μs |   1.601 μs | 0.0878 μs |  7.403 μs |  7.564 μs |     896 B |
| InterpolatedFormat | 1      |  5.894 μs |   1.652 μs | 0.0905 μs |  5.792 μs |  5.962 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.435 μs** | **141.709 μs** | **7.7675 μs** | **32.756 μs** | **46.401 μs** |   **14336 B** |
| StringFormat       | 100    | 38.494 μs | 126.375 μs | 6.9271 μs | 34.489 μs | 46.492 μs |   16736 B |
| InterpolatedFormat | 100    | 36.679 μs | 146.472 μs | 8.0286 μs | 31.830 μs | 45.946 μs |   14336 B |
