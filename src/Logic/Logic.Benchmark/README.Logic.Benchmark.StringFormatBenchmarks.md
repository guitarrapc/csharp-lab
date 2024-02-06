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
| **CompositeFormat**    | **1**      |  **6.032 μs** |   **0.8360 μs** |  **0.0458 μs** |  **5.981 μs** |  **6.072 μs** |     **872 B** |
| StringFormat       | 1      |  7.123 μs |   0.7952 μs |  0.0436 μs |  7.093 μs |  7.173 μs |     896 B |
| InterpolatedFormat | 1      |  6.435 μs |   2.4727 μs |  0.1355 μs |  6.301 μs |  6.572 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.627 μs** | **195.8194 μs** | **10.7335 μs** | **44.112 μs** | **63.919 μs** |   **14336 B** |
| StringFormat       | 100    | 46.438 μs |  10.2215 μs |  0.5603 μs | 45.827 μs | 46.928 μs |   16736 B |
| InterpolatedFormat | 100    | 35.233 μs | 161.0941 μs |  8.8301 μs | 30.090 μs | 45.429 μs |   14336 B |
