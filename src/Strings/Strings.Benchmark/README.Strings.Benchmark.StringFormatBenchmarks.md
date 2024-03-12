```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.276 μs** |  **16.652 μs** | **0.9127 μs** |  **5.431 μs** |  **7.244 μs** |     **872 B** |
| StringFormat       | 1      |  6.784 μs |  10.301 μs | 0.5646 μs |  6.337 μs |  7.418 μs |     896 B |
| InterpolatedFormat | 1      |  5.898 μs |   9.627 μs | 0.5277 μs |  5.531 μs |  6.503 μs |     872 B |
| **CompositeFormat**    | **100**    | **64.029 μs** |  **93.681 μs** | **5.1350 μs** | **60.182 μs** | **69.860 μs** |   **14336 B** |
| StringFormat       | 100    | 37.104 μs | 126.633 μs | 6.9412 μs | 33.036 μs | 45.118 μs |   16736 B |
| InterpolatedFormat | 100    | 34.682 μs | 149.353 μs | 8.1866 μs | 29.329 μs | 44.106 μs |   14336 B |
