```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.191 μs** |   **1.4515 μs** |  **0.0796 μs** |  **6.222 μs** |  **6.101 μs** |  **6.251 μs** |     **872 B** |
| StringFormat       | 1      |  6.315 μs |   0.6972 μs |  0.0382 μs |  6.332 μs |  6.271 μs |  6.343 μs |     896 B |
| InterpolatedFormat | 1      |  5.955 μs |   1.6359 μs |  0.0897 μs |  5.961 μs |  5.862 μs |  6.041 μs |     872 B |
| **CompositeFormat**    | **100**    | **50.604 μs** | **227.3142 μs** | **12.4599 μs** | **43.450 μs** | **43.370 μs** | **64.992 μs** |   **14336 B** |
| StringFormat       | 100    | 62.119 μs | 154.4225 μs |  8.4644 μs | 57.597 μs | 56.876 μs | 71.884 μs |   16736 B |
| InterpolatedFormat | 100    | 41.896 μs | 323.4295 μs | 17.7283 μs | 32.075 μs | 31.253 μs | 62.361 μs |   14336 B |
