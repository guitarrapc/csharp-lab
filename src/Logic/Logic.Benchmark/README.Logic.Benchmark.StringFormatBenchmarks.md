```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.736 μs** |   **0.5320 μs** |  **0.0292 μs** |  **6.702 μs** |  **6.753 μs** |     **872 B** |
| StringFormat       | 1      |  7.350 μs |   9.8732 μs |  0.5412 μs |  7.023 μs |  7.975 μs |     896 B |
| InterpolatedFormat | 1      |  5.831 μs |   1.5587 μs |  0.0854 μs |  5.751 μs |  5.921 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.658 μs** | **114.9677 μs** |  **6.3018 μs** | **32.841 μs** | **43.932 μs** |   **14336 B** |
| StringFormat       | 100    | 40.560 μs | 198.7753 μs | 10.8955 μs | 33.804 μs | 53.129 μs |   16736 B |
| InterpolatedFormat | 100    | 43.000 μs | 227.5563 μs | 12.4731 μs | 30.346 μs | 55.284 μs |   14336 B |
