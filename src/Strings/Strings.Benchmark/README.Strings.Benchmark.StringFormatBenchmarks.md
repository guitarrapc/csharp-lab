```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.499 μs** |   **8.7549 μs** |  **0.4799 μs** |  **6.242 μs** |  **6.203 μs** |  **7.053 μs** |     **872 B** |
| StringFormat       | 1      |  6.168 μs |   1.4762 μs |  0.0809 μs |  6.182 μs |  6.081 μs |  6.241 μs |     896 B |
| InterpolatedFormat | 1      |  6.394 μs |   0.5654 μs |  0.0310 μs |  6.388 μs |  6.367 μs |  6.428 μs |     872 B |
| **CompositeFormat**    | **100**    | **43.064 μs** | **327.7816 μs** | **17.9668 μs** | **32.892 μs** | **32.491 μs** | **63.809 μs** |   **14336 B** |
| StringFormat       | 100    | 45.144 μs |   9.8154 μs |  0.5380 μs | 45.244 μs | 44.563 μs | 45.625 μs |   16736 B |
| InterpolatedFormat | 100    | 36.170 μs | 114.9306 μs |  6.2997 μs | 33.802 μs | 31.398 μs | 43.311 μs |   14336 B |
