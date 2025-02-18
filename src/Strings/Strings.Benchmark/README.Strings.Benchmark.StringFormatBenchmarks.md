```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.968 μs** |   **6.7753 μs** |  **0.3714 μs** |  **6.867 μs** |  **6.657 μs** |  **7.380 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.422 μs |   0.1827 μs |  0.0100 μs |  6.423 μs |  6.412 μs |  6.432 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.908 μs |   2.5994 μs |  0.1425 μs |  5.841 μs |  5.812 μs |  6.072 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.252 μs |   1.3774 μs |  0.0755 μs |  6.262 μs |  6.172 μs |  6.322 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.615 μs |  19.0905 μs |  1.0464 μs |  6.922 μs |  5.449 μs |  7.473 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.860 μs |   0.4723 μs |  0.0259 μs |  5.870 μs |  5.831 μs |  5.880 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **43.915 μs** | **379.0570 μs** | **20.7774 μs** | **31.930 μs** | **31.909 μs** | **67.907 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.714 μs | 133.9701 μs |  7.3434 μs | 34.569 μs | 34.380 μs | 47.193 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.608 μs | 148.0250 μs |  8.1137 μs | 32.090 μs | 31.759 μs | 45.975 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 53.195 μs | 343.4959 μs | 18.8282 μs | 43.147 μs | 41.523 μs | 74.915 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 31.412 μs | 145.1005 μs |  7.9534 μs | 26.871 μs | 26.770 μs | 40.596 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 31.088 μs | 211.0968 μs | 11.5709 μs | 24.756 μs | 24.065 μs | 44.443 μs |   14336 B |
