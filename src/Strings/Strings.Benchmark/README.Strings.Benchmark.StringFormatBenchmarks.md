```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.981 μs** |   **4.481 μs** |  **0.2456 μs** |  **5.740 μs** |  **6.231 μs** |     **872 B** |
| StringFormat       | 1      |  6.974 μs |  10.775 μs |  0.5906 μs |  6.303 μs |  7.415 μs |     896 B |
| InterpolatedFormat | 1      |  6.131 μs |   8.407 μs |  0.4608 μs |  5.840 μs |  6.662 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.167 μs** | **202.184 μs** | **11.0824 μs** | **42.709 μs** | **61.964 μs** |   **14336 B** |
| StringFormat       | 100    | 39.806 μs | 140.645 μs |  7.7093 μs | 34.190 μs | 48.596 μs |   16736 B |
| InterpolatedFormat | 100    | 35.994 μs | 148.527 μs |  8.1413 μs | 31.259 μs | 45.395 μs |   14336 B |
