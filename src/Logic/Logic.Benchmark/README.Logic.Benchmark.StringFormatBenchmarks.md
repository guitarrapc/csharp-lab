```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.890 μs** |   **6.6486 μs** | **0.3644 μs** |  **5.579 μs** |  **6.291 μs** |     **872 B** |
| StringFormat       | 1      |  7.240 μs |   8.0126 μs | 0.4392 μs |  6.742 μs |  7.573 μs |     896 B |
| InterpolatedFormat | 1      |  5.844 μs |   0.8551 μs | 0.0469 μs |  5.791 μs |  5.880 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.380 μs** | **168.6174 μs** | **9.2425 μs** | **31.840 μs** | **48.050 μs** |   **14336 B** |
| StringFormat       | 100    | 39.256 μs | 153.1940 μs | 8.3971 μs | 34.264 μs | 48.951 μs |   16736 B |
| InterpolatedFormat | 100    | 35.844 μs | 129.4343 μs | 7.0947 μs | 31.529 μs | 44.032 μs |   14336 B |
