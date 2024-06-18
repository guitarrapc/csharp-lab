```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.075 μs** |   **2.181 μs** |  **0.1195 μs** |  **6.021 μs** |  **5.992 μs** |  **6.212 μs** |     **872 B** |
| StringFormat       | 1      |  7.138 μs |   2.252 μs |  0.1235 μs |  7.189 μs |  6.997 μs |  7.229 μs |     896 B |
| InterpolatedFormat | 1      |  5.781 μs |   2.545 μs |  0.1395 μs |  5.711 μs |  5.691 μs |  5.942 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.132 μs** | **123.736 μs** |  **6.7824 μs** | **33.322 μs** | **33.112 μs** | **44.963 μs** |   **14336 B** |
| StringFormat       | 100    | 42.376 μs | 158.790 μs |  8.7038 μs | 40.245 μs | 34.935 μs | 51.947 μs |   16736 B |
| InterpolatedFormat | 100    | 41.715 μs | 319.204 μs | 17.4966 μs | 31.901 μs | 31.328 μs | 61.916 μs |   14336 B |
