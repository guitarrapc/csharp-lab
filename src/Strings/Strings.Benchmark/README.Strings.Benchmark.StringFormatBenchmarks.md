```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.447 μs** |   **7.058 μs** |  **0.3869 μs** |  **6.045 μs** |  **6.817 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.784 μs |  10.208 μs |  0.5596 μs |  6.268 μs |  7.378 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.850 μs |   4.512 μs |  0.2473 μs |  5.619 μs |  6.111 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.340 μs |   1.196 μs |  0.0656 μs |  5.280 μs |  5.410 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.287 μs |   5.500 μs |  0.3015 μs |  4.940 μs |  5.481 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.784 μs |   2.352 μs |  0.1289 μs |  5.690 μs |  5.931 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **37.399 μs** | **129.689 μs** |  **7.1087 μs** | **33.091 μs** | **45.604 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 37.758 μs | 126.276 μs |  6.9216 μs | 33.533 μs | 45.745 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.671 μs | 151.454 μs |  8.3017 μs | 31.758 μs | 46.256 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 31.870 μs | 192.477 μs | 10.5503 μs | 25.368 μs | 44.043 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.865 μs | 147.264 μs |  8.0720 μs | 27.170 μs | 41.186 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 42.684 μs | 256.900 μs | 14.0816 μs | 34.550 μs | 58.944 μs |   14336 B |
