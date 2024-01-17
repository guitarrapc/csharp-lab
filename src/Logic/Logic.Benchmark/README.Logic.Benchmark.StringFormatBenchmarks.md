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
| **CompositeFormat**    | **1**      |  **6.802 μs** |   **3.9568 μs** |  **0.2169 μs** |  **6.622 μs** |  **7.043 μs** |     **872 B** |
| StringFormat       | 1      |  7.281 μs |   0.5574 μs |  0.0306 μs |  7.254 μs |  7.314 μs |     896 B |
| InterpolatedFormat | 1      |  5.793 μs |   2.4088 μs |  0.1320 μs |  5.650 μs |  5.910 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.990 μs** | **142.2052 μs** |  **7.7947 μs** | **32.281 μs** | **45.987 μs** |   **14336 B** |
| StringFormat       | 100    | 51.877 μs | 212.4521 μs | 11.6452 μs | 44.672 μs | 65.311 μs |   16736 B |
| InterpolatedFormat | 100    | 35.363 μs | 164.1996 μs |  9.0003 μs | 30.147 μs | 45.756 μs |   14336 B |
