```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.152 μs** |   **3.604 μs** |  **0.1975 μs** |  **6.213 μs** |  **5.931 μs** |  **6.312 μs** |     **872 B** |
| StringFormat       | 1      |  5.982 μs |   5.805 μs |  0.3182 μs |  5.902 μs |  5.712 μs |  6.332 μs |     896 B |
| InterpolatedFormat | 1      |  5.096 μs |   2.490 μs |  0.1365 μs |  5.159 μs |  4.939 μs |  5.189 μs |     584 B |
| **CompositeFormat**    | **100**    | **47.098 μs** | **141.979 μs** |  **7.7823 μs** | **43.251 μs** | **41.989 μs** | **56.055 μs** |   **14048 B** |
| StringFormat       | 100    | 31.654 μs | 156.369 μs |  8.5711 μs | 27.055 μs | 26.364 μs | 41.544 μs |   16736 B |
| InterpolatedFormat | 100    | 40.249 μs | 499.396 μs | 27.3736 μs | 24.777 μs | 24.116 μs | 71.856 μs |   14048 B |
