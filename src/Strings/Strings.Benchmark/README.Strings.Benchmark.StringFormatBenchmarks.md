```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.144 μs** |   **1.693 μs** | **0.0928 μs** |  **6.041 μs** |  **6.221 μs** |     **872 B** |
| StringFormat       | 1      |  6.248 μs |   1.059 μs | 0.0580 μs |  6.181 μs |  6.282 μs |     896 B |
| InterpolatedFormat | 1      |  6.690 μs |   1.242 μs | 0.0681 μs |  6.613 μs |  6.743 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.161 μs** | **130.546 μs** | **7.1557 μs** | **31.919 μs** | **44.422 μs** |   **14336 B** |
| StringFormat       | 100    | 39.208 μs | 150.432 μs | 8.2457 μs | 34.008 μs | 48.715 μs |   16736 B |
| InterpolatedFormat | 100    | 36.163 μs | 124.580 μs | 6.8286 μs | 32.206 μs | 44.047 μs |   14336 B |
