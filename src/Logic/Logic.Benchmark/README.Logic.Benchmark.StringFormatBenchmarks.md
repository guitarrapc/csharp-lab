```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.994 μs** |   **0.8725 μs** |  **0.0478 μs** |  **5.940 μs** |  **6.031 μs** |     **872 B** |
| StringFormat       | 1      |  7.336 μs |   4.6106 μs |  0.2527 μs |  7.102 μs |  7.604 μs |     896 B |
| InterpolatedFormat | 1      |  5.689 μs |   2.9258 μs |  0.1604 μs |  5.535 μs |  5.856 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.117 μs** | **119.6619 μs** |  **6.5591 μs** | **32.260 μs** | **43.690 μs** |   **14336 B** |
| StringFormat       | 100    | 52.234 μs | 255.5412 μs | 14.0071 μs | 44.023 μs | 68.407 μs |   16736 B |
| InterpolatedFormat | 100    | 35.173 μs | 128.9285 μs |  7.0670 μs | 30.597 μs | 43.312 μs |   14336 B |
