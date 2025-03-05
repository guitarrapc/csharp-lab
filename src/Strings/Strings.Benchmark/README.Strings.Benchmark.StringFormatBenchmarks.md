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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.098 μs** |   **1.014 μs** |  **0.0556 μs** |  **6.102 μs** |  **6.041 μs** |  **6.152 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.686 μs |   8.452 μs |  0.4633 μs |  6.633 μs |  6.252 μs |  7.174 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.381 μs |   8.858 μs |  0.4856 μs |  6.492 μs |  5.850 μs |  6.802 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      | 12.009 μs | 186.214 μs | 10.2070 μs |  6.252 μs |  5.981 μs | 23.794 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.644 μs |   1.040 μs |  0.0570 μs |  5.661 μs |  5.580 μs |  5.690 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  6.661 μs |   2.628 μs |  0.1440 μs |  6.579 μs |  6.577 μs |  6.827 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **65.293 μs** | **450.678 μs** | **24.7032 μs** | **53.705 μs** | **48.516 μs** | **93.660 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 52.029 μs | 227.678 μs | 12.4798 μs | 44.869 μs | 44.778 μs | 66.439 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 52.069 μs | 494.675 μs | 27.1148 μs | 40.090 μs | 33.008 μs | 83.111 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 30.303 μs | 152.975 μs |  8.3851 μs | 25.577 μs | 25.347 μs | 39.984 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 40.395 μs |  93.624 μs |  5.1319 μs | 37.640 μs | 37.229 μs | 46.316 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.655 μs | 146.426 μs |  8.0261 μs | 25.096 μs | 24.946 μs | 38.922 μs |   14336 B |
