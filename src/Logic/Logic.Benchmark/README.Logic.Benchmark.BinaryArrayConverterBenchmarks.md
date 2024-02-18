```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.89 ns** |   **6.371 ns** | **0.349 ns** |  **17.56 ns** |  **18.25 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.24 ns |   1.962 ns | 0.108 ns |  67.17 ns |  67.36 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.39 ns |   3.034 ns | 0.166 ns |  20.20 ns |  20.51 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.02 ns |   3.921 ns | 0.215 ns |  10.81 ns |  11.24 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **206.60 ns** | **152.562 ns** | **8.362 ns** | **201.14 ns** | **216.23 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 696.29 ns |  31.966 ns | 1.752 ns | 694.37 ns | 697.80 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 228.25 ns | 119.846 ns | 6.569 ns | 221.00 ns | 233.80 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 147.49 ns |  71.776 ns | 3.934 ns | 143.61 ns | 151.48 ns | 0.0038 |     320 B |
