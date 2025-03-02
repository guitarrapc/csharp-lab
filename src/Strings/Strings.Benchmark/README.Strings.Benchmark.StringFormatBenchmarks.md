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
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.114 μs** |   **0.6907 μs** |  **0.0379 μs** |  **6.131 μs** |  **6.071 μs** |  **6.141 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.146 μs |   1.9507 μs |  0.1069 μs |  7.203 μs |  7.023 μs |  7.213 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.757 μs |   2.6611 μs |  0.1459 μs |  5.780 μs |  5.601 μs |  5.890 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.406 μs |   7.7382 μs |  0.4242 μs |  5.550 μs |  4.929 μs |  5.740 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  6.576 μs |  11.2970 μs |  0.6192 μs |  6.823 μs |  5.871 μs |  7.033 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.299 μs |   7.0216 μs |  0.3849 μs |  5.179 μs |  4.989 μs |  5.730 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **39.223 μs** | **199.6213 μs** | **10.9419 μs** | **33.042 μs** | **32.771 μs** | **51.857 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.948 μs | 147.4609 μs |  8.0828 μs | 34.473 μs | 34.093 μs | 48.279 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 35.877 μs | 120.9660 μs |  6.6306 μs | 32.200 μs | 31.899 μs | 43.531 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 30.647 μs | 161.6297 μs |  8.8595 μs | 25.678 μs | 25.388 μs | 40.876 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 38.686 μs |  47.8352 μs |  2.6220 μs | 37.910 μs | 36.539 μs | 41.608 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 42.153 μs | 273.3715 μs | 14.9844 μs | 33.617 μs | 33.386 μs | 59.455 μs |   14336 B |
