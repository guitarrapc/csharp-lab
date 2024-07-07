```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.194 μs** |   **4.113 μs** | **0.2255 μs** |  **5.961 μs** |  **6.411 μs** |     **872 B** |
| StringFormat       | 1      |  6.946 μs |   9.821 μs | 0.5383 μs |  6.331 μs |  7.333 μs |     896 B |
| InterpolatedFormat | 1      |  5.832 μs |   1.377 μs | 0.0755 μs |  5.752 μs |  5.902 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.465 μs** | **123.993 μs** | **6.7965 μs** | **32.461 μs** | **44.312 μs** |   **14336 B** |
| StringFormat       | 100    | 39.971 μs | 154.486 μs | 8.4679 μs | 34.775 μs | 49.742 μs |   16736 B |
| InterpolatedFormat | 100    | 36.679 μs | 160.071 μs | 8.7740 μs | 31.439 μs | 46.808 μs |   14336 B |
