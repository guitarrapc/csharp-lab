```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.431 μs** |   **3.344 μs** |  **0.1833 μs** |  **5.231 μs** |  **5.591 μs** |     **584 B** |
| StringFormat       | 1      |  5.955 μs |   9.314 μs |  0.5105 μs |  5.511 μs |  6.513 μs |     896 B |
| InterpolatedFormat | 1      |  6.283 μs |   8.161 μs |  0.4473 μs |  5.886 μs |  6.768 μs |     584 B |
| **CompositeFormat**    | **100**    | **40.719 μs** |  **28.082 μs** |  **1.5393 μs** | **39.624 μs** | **42.480 μs** |   **14048 B** |
| StringFormat       | 100    | 49.038 μs | 183.514 μs | 10.0590 μs | 38.982 μs | 59.100 μs |   16736 B |
| InterpolatedFormat | 100    | 32.611 μs | 208.738 μs | 11.4416 μs | 25.428 μs | 45.806 μs |   14336 B |
