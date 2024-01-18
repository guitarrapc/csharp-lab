```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.313 μs** |   **6.228 μs** |  **0.3414 μs** |  **6.106 μs** |  **6.707 μs** |     **872 B** |
| StringFormat       | 1      |  7.117 μs |   1.961 μs |  0.1075 μs |  6.993 μs |  7.184 μs |     896 B |
| InterpolatedFormat | 1      |  5.523 μs |   5.985 μs |  0.3281 μs |  5.300 μs |  5.900 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.057 μs** | **166.411 μs** |  **9.1216 μs** | **32.791 μs** | **48.590 μs** |   **14336 B** |
| StringFormat       | 100    | 49.034 μs |  13.052 μs |  0.7154 μs | 48.450 μs | 49.832 μs |   16736 B |
| InterpolatedFormat | 100    | 48.858 μs | 230.994 μs | 12.6616 μs | 41.538 μs | 63.478 μs |   14336 B |
