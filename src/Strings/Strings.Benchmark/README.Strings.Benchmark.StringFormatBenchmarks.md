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
| **CompositeFormat**    | **1**      |  **6.011 μs** |   **2.936 μs** |  **0.1609 μs** |  **5.861 μs** |  **6.181 μs** |     **872 B** |
| StringFormat       | 1      |  7.021 μs |   6.487 μs |  0.3556 μs |  6.777 μs |  7.429 μs |     896 B |
| InterpolatedFormat | 1      |  5.694 μs |   2.252 μs |  0.1234 μs |  5.591 μs |  5.831 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.409 μs** | **128.991 μs** |  **7.0704 μs** | **33.784 μs** | **46.548 μs** |   **14336 B** |
| StringFormat       | 100    | 38.490 μs | 128.980 μs |  7.0698 μs | 34.038 μs | 46.642 μs |   16736 B |
| InterpolatedFormat | 100    | 50.298 μs | 212.906 μs | 11.6701 μs | 42.380 μs | 63.700 μs |   14336 B |
