```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error        | StdDev     | Median    | Min       | Max        | Allocated |
|------------------- |------- |----------:|-------------:|-----------:|----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.931 μs** |     **5.231 μs** |  **0.2867 μs** |  **5.901 μs** |  **5.661 μs** |   **6.232 μs** |     **872 B** |
| StringFormat       | 1      |  6.219 μs |     2.639 μs |  0.1446 μs |  6.302 μs |  6.052 μs |   6.303 μs |     896 B |
| InterpolatedFormat | 1      |  5.998 μs |     3.229 μs |  0.1770 μs |  5.911 μs |  5.882 μs |   6.202 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.946 μs** |   **138.337 μs** |  **7.5827 μs** | **32.862 μs** | **32.280 μs** |  **45.695 μs** |   **14336 B** |
| StringFormat       | 100    | 44.440 μs |   327.260 μs | 17.9382 μs | 34.254 μs | 33.913 μs |  65.152 μs |   16736 B |
| InterpolatedFormat | 100    | 68.655 μs | 1,118.969 μs | 61.3345 μs | 35.717 μs | 30.827 μs | 139.422 μs |   14336 B |
