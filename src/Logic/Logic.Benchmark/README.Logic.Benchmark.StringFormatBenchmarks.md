```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.978 μs** |   **1.863 μs** |  **0.1021 μs** |  **6.021 μs** |  **5.862 μs** |  **6.051 μs** |     **872 B** |
| StringFormat       | 1      |  6.179 μs |   4.196 μs |  0.2300 μs |  6.287 μs |  5.915 μs |  6.337 μs |     896 B |
| InterpolatedFormat | 1      |  5.894 μs |   1.401 μs |  0.0768 μs |  5.910 μs |  5.810 μs |  5.961 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.291 μs** | **344.444 μs** | **18.8801 μs** | **32.480 μs** | **32.300 μs** | **65.091 μs** |   **14336 B** |
| StringFormat       | 100    | 52.213 μs | 230.090 μs | 12.6120 μs | 45.163 μs | 44.703 μs | 66.774 μs |   16736 B |
| InterpolatedFormat | 100    | 41.690 μs | 194.008 μs | 10.6342 μs | 42.990 μs | 30.466 μs | 51.615 μs |   14336 B |
