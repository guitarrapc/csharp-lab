```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      | **12.204 μs** | **181.131 μs** |  **9.9284 μs** |  **7.059 μs** |  **5.905 μs** | **23.649 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.390 μs |   6.149 μs |  0.3370 μs |  7.353 μs |  7.073 μs |  7.744 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.245 μs |   8.201 μs |  0.4495 μs |  6.441 μs |  5.731 μs |  6.562 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.121 μs |   2.486 μs |  0.1363 μs |  6.111 μs |  5.990 μs |  6.262 μs |     584 B |
| StringFormat       | .NET 9.0 | 1      |  5.867 μs |  10.852 μs |  0.5948 μs |  5.720 μs |  5.360 μs |  6.522 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.572 μs |  18.124 μs |  0.9934 μs |  5.054 μs |  4.944 μs |  6.718 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **38.288 μs** | **196.206 μs** | **10.7547 μs** | **32.731 μs** | **31.448 μs** | **50.684 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 38.919 μs | 163.107 μs |  8.9404 μs | 33.894 μs | 33.623 μs | 49.242 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 39.450 μs | 177.226 μs |  9.7143 μs | 36.438 μs | 31.599 μs | 50.314 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 30.626 μs | 135.481 μs |  7.4262 μs | 26.886 μs | 25.814 μs | 39.179 μs |   14048 B |
| StringFormat       | .NET 9.0 | 100    | 32.642 μs | 189.156 μs | 10.3683 μs | 26.994 μs | 26.325 μs | 44.608 μs |   16448 B |
| InterpolatedFormat | .NET 9.0 | 100    | 36.860 μs |  15.806 μs |  0.8664 μs | 37.224 μs | 35.871 μs | 37.485 μs |   14048 B |
