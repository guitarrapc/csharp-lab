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
| **CompositeFormat**    | **1**      |  **6.305 μs** |   **3.211 μs** |  **0.1760 μs** |  **6.161 μs** |  **6.501 μs** |     **872 B** |
| StringFormat       | 1      |  7.060 μs |  10.206 μs |  0.5594 μs |  6.712 μs |  7.705 μs |     896 B |
| InterpolatedFormat | 1      |  7.380 μs |   5.827 μs |  0.3194 μs |  7.113 μs |  7.734 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.684 μs** | **211.298 μs** | **11.5819 μs** | **32.912 μs** | **56.066 μs** |   **14336 B** |
| StringFormat       | 100    | 37.658 μs | 127.955 μs |  7.0137 μs | 33.604 μs | 45.757 μs |   16736 B |
| InterpolatedFormat | 100    | 36.226 μs | 129.235 μs |  7.0838 μs | 32.071 μs | 44.405 μs |   14336 B |
