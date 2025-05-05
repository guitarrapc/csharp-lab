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
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.435 μs** |   **4.172 μs** |  **0.2287 μs** |  **6.562 μs** |  **6.171 μs** |  **6.572 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.373 μs |  20.787 μs |  1.1394 μs |  6.882 μs |  6.562 μs |  8.676 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.950 μs |   8.959 μs |  0.4911 μs |  6.713 μs |  6.623 μs |  7.515 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.265 μs |   7.949 μs |  0.4357 μs |  6.281 μs |  5.821 μs |  6.692 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.298 μs |   2.753 μs |  0.1509 μs |  5.285 μs |  5.154 μs |  5.455 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  4.849 μs |   1.455 μs |  0.0798 μs |  4.819 μs |  4.788 μs |  4.939 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **41.731 μs** | **151.929 μs** |  **8.3277 μs** | **46.276 μs** | **32.120 μs** | **46.797 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 50.010 μs |   7.975 μs |  0.4372 μs | 49.973 μs | 49.592 μs | 50.464 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.558 μs | 146.109 μs |  8.0087 μs | 32.070 μs | 31.799 μs | 45.804 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 36.898 μs | 171.553 μs |  9.4034 μs | 39.292 μs | 26.529 μs | 44.873 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 37.530 μs | 344.456 μs | 18.8808 μs | 26.810 μs | 26.450 μs | 59.331 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 36.357 μs | 396.358 μs | 21.7257 μs | 23.854 μs | 23.774 μs | 61.444 μs |   14336 B |
