```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.131 μs** |   **3.408 μs** |  **0.1868 μs** |  **6.161 μs** |  **5.931 μs** |  **6.301 μs** |     **872 B** |
| StringFormat       | 1      |  6.072 μs |   4.622 μs |  0.2534 μs |  6.142 μs |  5.791 μs |  6.283 μs |     896 B |
| InterpolatedFormat | 1      |  5.694 μs |   3.356 μs |  0.1840 μs |  5.630 μs |  5.551 μs |  5.902 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.162 μs** |  **19.107 μs** |  **1.0473 μs** | **44.131 μs** | **43.130 μs** | **45.224 μs** |   **14336 B** |
| StringFormat       | 100    | 43.558 μs | 324.708 μs | 17.7984 μs | 33.342 μs | 33.223 μs | 64.110 μs |   16736 B |
| InterpolatedFormat | 100    | 34.121 μs | 128.925 μs |  7.0668 μs | 30.187 μs | 29.896 μs | 42.279 μs |   14336 B |
