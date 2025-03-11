```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.059 μs** |   **2.887 μs** |  **0.1582 μs** |  **6.096 μs** |  **5.886 μs** |  **6.196 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.240 μs |   1.115 μs |  0.0611 μs |  7.253 μs |  7.173 μs |  7.293 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      | 11.658 μs | 185.880 μs | 10.1887 μs |  5.841 μs |  5.711 μs | 23.423 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.202 μs |   3.654 μs |  0.2003 μs |  6.152 μs |  6.032 μs |  6.423 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.302 μs |   1.104 μs |  0.0605 μs |  6.303 μs |  6.242 μs |  6.362 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.810 μs |   1.104 μs |  0.0605 μs |  5.810 μs |  5.750 μs |  5.871 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **46.445 μs** |  **29.188 μs** |  **1.5999 μs** | **47.324 μs** | **44.599 μs** | **47.413 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 41.034 μs | 200.936 μs | 11.0140 μs | 34.736 μs | 34.615 μs | 53.752 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 49.238 μs | 250.941 μs | 13.7549 μs | 41.357 μs | 41.237 μs | 65.121 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 48.453 μs | 197.395 μs | 10.8199 μs | 42.890 μs | 41.547 μs | 60.923 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 37.988 μs | 188.984 μs | 10.3589 μs | 40.145 μs | 26.721 μs | 47.099 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.097 μs | 149.093 μs |  8.1723 μs | 25.066 μs | 23.724 μs | 38.502 μs |   14048 B |
