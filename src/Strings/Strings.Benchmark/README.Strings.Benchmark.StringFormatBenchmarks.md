```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.064 μs** |   **2.277 μs** |  **0.1248 μs** |  **5.920 μs** |  **6.141 μs** |     **872 B** |
| StringFormat       | 1      |  7.098 μs |   8.673 μs |  0.4754 μs |  6.747 μs |  7.639 μs |     896 B |
| InterpolatedFormat | 1      |  5.502 μs |   3.904 μs |  0.2140 μs |  5.345 μs |  5.745 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.878 μs** | **219.706 μs** | **12.0429 μs** | **43.681 μs** | **64.781 μs** |   **14336 B** |
| StringFormat       | 100    | 47.508 μs |  42.500 μs |  2.3296 μs | 45.805 μs | 50.163 μs |   16736 B |
| InterpolatedFormat | 100    | 36.897 μs | 140.037 μs |  7.6759 μs | 32.456 μs | 45.761 μs |   14336 B |
