```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.125 μs** |  **10.090 μs** |  **0.5531 μs** |  **5.771 μs** |  **6.762 μs** |     **872 B** |
| StringFormat       | 1      |  6.210 μs |   6.737 μs |  0.3693 μs |  5.816 μs |  6.548 μs |     896 B |
| InterpolatedFormat | 1      |  5.690 μs |   1.316 μs |  0.0721 μs |  5.610 μs |  5.750 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.682 μs** | **313.632 μs** | **17.1912 μs** | **41.727 μs** | **71.533 μs** |   **14336 B** |
| StringFormat       | 100    | 36.408 μs | 135.075 μs |  7.4039 μs | 31.930 μs | 44.954 μs |   16736 B |
| InterpolatedFormat | 100    | 41.632 μs |  18.383 μs |  1.0076 μs | 40.781 μs | 42.745 μs |   14336 B |
