```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.363 μs** |   **6.0841 μs** |  **0.3335 μs** |  **4.979 μs** |  **5.580 μs** |     **872 B** |
| StringFormat       | 1      |  5.153 μs |   0.9943 μs |  0.0545 μs |  5.090 μs |  5.189 μs |     896 B |
| InterpolatedFormat | 1      |  5.436 μs |   8.5124 μs |  0.4666 μs |  4.899 μs |  5.731 μs |     872 B |
| **CompositeFormat**    | **100**    | **42.002 μs** | **260.0365 μs** | **14.2535 μs** | **25.719 μs** | **52.218 μs** |   **14336 B** |
| StringFormat       | 100    | 41.705 μs | 227.6670 μs | 12.4792 μs | 27.432 μs | 50.555 μs |   16736 B |
| InterpolatedFormat | 100    | 38.658 μs |  24.2246 μs |  1.3278 μs | 37.700 μs | 40.174 μs |   14336 B |
