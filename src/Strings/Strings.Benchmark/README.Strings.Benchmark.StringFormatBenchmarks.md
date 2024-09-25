```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      | **13.255 μs** | **210.382 μs** | **11.5318 μs** |  **6.633 μs** |  **6.562 μs** | **26.571 μs** |     **872 B** |
| StringFormat       | 1      |  7.480 μs |   9.459 μs |  0.5185 μs |  7.243 μs |  7.123 μs |  8.075 μs |     896 B |
| InterpolatedFormat | 1      |  5.911 μs |   1.749 μs |  0.0959 μs |  5.921 μs |  5.811 μs |  6.002 μs |     872 B |
| **CompositeFormat**    | **100**    | **56.767 μs** | **409.834 μs** | **22.4644 μs** | **43.953 μs** | **43.642 μs** | **82.706 μs** |   **14336 B** |
| StringFormat       | 100    | 38.666 μs | 129.140 μs |  7.0786 μs | 35.317 μs | 33.884 μs | 46.798 μs |   16736 B |
| InterpolatedFormat | 100    | 43.276 μs |  43.564 μs |  2.3879 μs | 42.895 μs | 41.102 μs | 45.831 μs |   14336 B |
