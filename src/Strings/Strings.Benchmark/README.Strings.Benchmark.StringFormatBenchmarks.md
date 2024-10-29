```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.373 μs** |   **3.0867 μs** |  **0.1692 μs** |  **6.256 μs** |  **6.567 μs** |     **872 B** |
| StringFormat       | 1      |  7.120 μs |   1.5688 μs |  0.0860 μs |  7.022 μs |  7.184 μs |     896 B |
| InterpolatedFormat | 1      |  5.938 μs |   0.5574 μs |  0.0306 μs |  5.911 μs |  5.971 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.703 μs** | **170.1650 μs** |  **9.3273 μs** | **33.253 μs** | **49.473 μs** |   **14336 B** |
| StringFormat       | 100    | 72.112 μs | 224.6517 μs | 12.3139 μs | 62.497 μs | 85.991 μs |   16736 B |
| InterpolatedFormat | 100    | 36.995 μs | 155.6534 μs |  8.5319 μs | 31.845 μs | 46.843 μs |   14336 B |
