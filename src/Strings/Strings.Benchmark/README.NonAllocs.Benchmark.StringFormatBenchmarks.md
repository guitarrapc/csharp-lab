```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.164 μs** |   **1.069 μs** |  **0.0586 μs** |  **6.097 μs** |  **6.207 μs** |     **872 B** |
| StringFormat       | 1      |  7.079 μs |  10.451 μs |  0.5728 μs |  6.421 μs |  7.464 μs |     896 B |
| InterpolatedFormat | 1      |  5.871 μs |   2.737 μs |  0.1500 μs |  5.721 μs |  6.021 μs |     872 B |
| **CompositeFormat**    | **100**    | **67.014 μs** | **174.770 μs** |  **9.5797 μs** | **60.410 μs** | **78.001 μs** |   **14336 B** |
| StringFormat       | 100    | 50.284 μs | 222.644 μs | 12.2039 μs | 42.900 μs | 64.370 μs |   16736 B |
| InterpolatedFormat | 100    | 49.075 μs | 261.135 μs | 14.3137 μs | 40.776 μs | 65.603 μs |   14336 B |
