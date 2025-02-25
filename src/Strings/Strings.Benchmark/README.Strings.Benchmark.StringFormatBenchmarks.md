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
| Method             | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.796 μs** |   **5.437 μs** | **0.2980 μs** |  **6.452 μs** |  **6.983 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  8.474 μs |  26.898 μs | 1.4744 μs |  7.189 μs | 10.084 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.310 μs |   7.805 μs | 0.4278 μs |  5.996 μs |  6.797 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.984 μs |   8.555 μs | 0.4689 μs |  5.660 μs |  6.522 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.563 μs |   1.655 μs | 0.0907 μs |  5.480 μs |  5.660 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.379 μs |   1.983 μs | 0.1087 μs |  5.289 μs |  5.500 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **46.908 μs** | **126.895 μs** | **6.9555 μs** | **42.450 μs** | **54.922 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 40.302 μs | 175.966 μs | 9.6453 μs | 34.495 μs | 51.436 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.389 μs | 155.394 μs | 8.5176 μs | 31.169 μs | 46.218 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 43.029 μs | 133.433 μs | 7.3139 μs | 35.672 μs | 50.298 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.734 μs | 166.176 μs | 9.1087 μs | 27.050 μs | 43.240 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 40.619 μs | 102.800 μs | 5.6348 μs | 36.858 μs | 47.097 μs |   14048 B |
