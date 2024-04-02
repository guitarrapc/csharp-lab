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
| **CompositeFormat**    | **1**      |  **6.102 μs** |   **1.277 μs** |  **0.0700 μs** |  **6.072 μs** |  **6.052 μs** |  **6.182 μs** |     **872 B** |
| StringFormat       | 1      |  6.723 μs |   8.764 μs |  0.4804 μs |  6.503 μs |  6.392 μs |  7.274 μs |     896 B |
| InterpolatedFormat | 1      |  6.495 μs |   2.432 μs |  0.1333 μs |  6.461 μs |  6.382 μs |  6.642 μs |     872 B |
| **CompositeFormat**    | **100**    | **42.291 μs** | **320.953 μs** | **17.5925 μs** | **32.406 μs** | **31.864 μs** | **62.602 μs** |   **14336 B** |
| StringFormat       | 100    | 37.311 μs | 117.773 μs |  6.4555 μs | 33.634 μs | 33.534 μs | 44.765 μs |   16736 B |
| InterpolatedFormat | 100    | 48.584 μs | 244.934 μs | 13.4256 μs | 41.247 μs | 40.425 μs | 64.079 μs |   14336 B |
