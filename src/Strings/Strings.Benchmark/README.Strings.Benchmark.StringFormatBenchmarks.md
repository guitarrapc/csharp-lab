```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.880 μs** |   **6.133 μs** |  **0.3362 μs** |  **5.976 μs** |  **5.505 μs** |  **6.157 μs** |     **872 B** |
| StringFormat       | 1      |  5.697 μs |   7.426 μs |  0.4071 μs |  5.530 μs |  5.400 μs |  6.161 μs |     896 B |
| InterpolatedFormat | 1      |  8.147 μs |  12.090 μs |  0.6627 μs |  8.431 μs |  7.389 μs |  8.620 μs |     584 B |
| **CompositeFormat**    | **100**    | **39.418 μs** |  **12.440 μs** |  **0.6819 μs** | **39.669 μs** | **38.647 μs** | **39.940 μs** |   **14048 B** |
| StringFormat       | 100    | 35.828 μs | 202.499 μs | 11.0997 μs | 30.191 μs | 28.678 μs | 48.615 μs |   16736 B |
| InterpolatedFormat | 100    | 33.174 μs | 262.375 μs | 14.3817 μs | 25.122 μs | 24.622 μs | 49.778 μs |   14336 B |
