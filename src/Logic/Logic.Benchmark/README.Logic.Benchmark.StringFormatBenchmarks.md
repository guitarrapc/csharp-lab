```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.729 μs** |   **3.842 μs** | **0.2106 μs** |  **5.516 μs** |  **5.936 μs** |     **872 B** |
| StringFormat       | 1      |  6.093 μs |   6.875 μs | 0.3769 μs |  5.736 μs |  6.487 μs |     896 B |
| InterpolatedFormat | 1      |  6.206 μs |   8.813 μs | 0.4831 μs |  5.672 μs |  6.613 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.625 μs** | **128.822 μs** | **7.0612 μs** | **32.010 μs** | **44.754 μs** |   **14336 B** |
| StringFormat       | 100    | 37.232 μs | 136.717 μs | 7.4939 μs | 32.821 μs | 45.885 μs |   16736 B |
| InterpolatedFormat | 100    | 34.038 μs | 140.283 μs | 7.6894 μs | 29.439 μs | 42.916 μs |   14336 B |
