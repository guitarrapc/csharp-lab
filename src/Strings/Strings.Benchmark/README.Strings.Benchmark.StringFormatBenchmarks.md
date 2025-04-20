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
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.916 μs** |   **4.067 μs** |  **0.2229 μs** |  **6.792 μs** |  **6.782 μs** |  **7.173 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.257 μs |   1.239 μs |  0.0679 μs |  7.234 μs |  7.203 μs |  7.333 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.345 μs |   2.020 μs |  0.1107 μs |  6.292 μs |  6.271 μs |  6.473 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.315 μs |   4.859 μs |  0.2663 μs |  6.171 μs |  6.152 μs |  6.622 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.729 μs |   6.762 μs |  0.3706 μs |  5.535 μs |  5.495 μs |  6.157 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  7.035 μs |  50.447 μs |  2.7652 μs |  5.566 μs |  5.314 μs | 10.225 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **39.827 μs** | **132.275 μs** |  **7.2504 μs** | **35.676 μs** | **35.606 μs** | **48.199 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 40.734 μs | 201.845 μs | 11.0638 μs | 34.660 μs | 34.038 μs | 53.505 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 35.201 μs | 132.638 μs |  7.2703 μs | 31.023 μs | 30.984 μs | 43.596 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 48.931 μs | 726.869 μs | 39.8421 μs | 25.998 μs | 25.858 μs | 94.936 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 44.630 μs | 237.702 μs | 13.0293 μs | 37.380 μs | 36.839 μs | 59.672 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 29.605 μs | 144.683 μs |  7.9306 μs | 25.066 μs | 24.986 μs | 38.762 μs |   14048 B |
