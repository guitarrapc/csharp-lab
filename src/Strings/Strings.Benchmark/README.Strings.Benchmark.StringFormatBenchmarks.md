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
| **CompositeFormat**    | **1**      |  **6.332 μs** |   **4.633 μs** |  **0.2539 μs** |  **6.151 μs** |  **6.622 μs** |     **872 B** |
| StringFormat       | 1      |  8.195 μs |  25.653 μs |  1.4061 μs |  7.343 μs |  9.818 μs |     896 B |
| InterpolatedFormat | 1      |  7.708 μs |   9.150 μs |  0.5015 μs |  7.194 μs |  8.196 μs |     872 B |
| **CompositeFormat**    | **100**    | **65.933 μs** | **176.079 μs** |  **9.6515 μs** | **59.221 μs** | **76.994 μs** |   **14336 B** |
| StringFormat       | 100    | 38.652 μs | 145.968 μs |  8.0010 μs | 33.893 μs | 47.889 μs |   16736 B |
| InterpolatedFormat | 100    | 50.363 μs | 211.898 μs | 11.6148 μs | 43.577 μs | 63.774 μs |   14336 B |
