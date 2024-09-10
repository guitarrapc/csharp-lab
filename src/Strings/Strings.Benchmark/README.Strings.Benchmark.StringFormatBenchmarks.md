```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.618 μs** |   **4.769 μs** |  **0.2614 μs** |  **6.321 μs** |  **6.812 μs** |     **872 B** |
| StringFormat       | 1      |  6.328 μs |   1.899 μs |  0.1041 μs |  6.211 μs |  6.411 μs |     896 B |
| InterpolatedFormat | 1      |  6.056 μs |  10.326 μs |  0.5660 μs |  5.625 μs |  6.697 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.407 μs** | **122.364 μs** |  **6.7072 μs** | **32.440 μs** | **44.151 μs** |   **14336 B** |
| StringFormat       | 100    | 52.951 μs | 239.899 μs | 13.1497 μs | 44.913 μs | 68.126 μs |   16736 B |
| InterpolatedFormat | 100    | 42.586 μs | 212.275 μs | 11.6355 μs | 30.777 μs | 54.041 μs |   14336 B |
