```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.339 μs** |  **10.479 μs** |  **0.5744 μs** |  **5.882 μs** |  **6.984 μs** |     **872 B** |
| StringFormat       | 1      |  7.047 μs |   5.515 μs |  0.3023 μs |  6.843 μs |  7.394 μs |     896 B |
| InterpolatedFormat | 1      |  5.657 μs |   5.313 μs |  0.2912 μs |  5.359 μs |  5.941 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.642 μs** | **134.132 μs** |  **7.3522 μs** | **32.090 μs** | **45.123 μs** |   **14336 B** |
| StringFormat       | 100    | 51.017 μs | 222.316 μs | 12.1859 μs | 43.856 μs | 65.088 μs |   16736 B |
| InterpolatedFormat | 100    | 34.945 μs | 141.061 μs |  7.7320 μs | 30.356 μs | 43.872 μs |   14336 B |
