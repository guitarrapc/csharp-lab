```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.944 μs** |   **3.946 μs** |  **0.2163 μs** |  **5.790 μs** |  **6.191 μs** |     **872 B** |
| StringFormat       | 1      |  7.185 μs |   3.230 μs |  0.1771 μs |  7.068 μs |  7.389 μs |     896 B |
| InterpolatedFormat | 1      |  5.690 μs |   1.749 μs |  0.0959 μs |  5.590 μs |  5.781 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.410 μs** | **202.403 μs** | **11.0944 μs** | **42.995 μs** | **62.221 μs** |   **14336 B** |
| StringFormat       | 100    | 37.414 μs | 137.683 μs |  7.5468 μs | 32.942 μs | 46.127 μs |   16736 B |
| InterpolatedFormat | 100    | 36.523 μs | 137.398 μs |  7.5313 μs | 32.164 μs | 45.219 μs |   14336 B |
