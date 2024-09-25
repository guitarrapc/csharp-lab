```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.609 μs** |  **13.094 μs** |  **0.7177 μs** |  **6.131 μs** |  **7.434 μs** |     **872 B** |
| StringFormat       | 1      |  6.527 μs |   1.740 μs |  0.0954 μs |  6.438 μs |  6.628 μs |     896 B |
| InterpolatedFormat | 1      |  6.008 μs |   3.141 μs |  0.1721 μs |  5.871 μs |  6.201 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.775 μs** | **128.016 μs** |  **7.0170 μs** | **33.043 μs** | **45.837 μs** |   **14336 B** |
| StringFormat       | 100    | 52.228 μs | 221.231 μs | 12.1264 μs | 44.874 μs | 66.224 μs |   16736 B |
| InterpolatedFormat | 100    | 37.965 μs | 129.834 μs |  7.1166 μs | 32.772 μs | 46.077 μs |   14336 B |
