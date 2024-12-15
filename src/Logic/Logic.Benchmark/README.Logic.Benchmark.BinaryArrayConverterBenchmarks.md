```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.81 ns** |  **6.903 ns** | **0.378 ns** |  **17.37 ns** |  **18.06 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.68 ns |  3.850 ns | 0.211 ns |  64.48 ns |  64.90 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.64 ns |  6.431 ns | 0.353 ns |  20.24 ns |  20.86 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.83 ns |  0.670 ns | 0.037 ns |  10.79 ns |  10.85 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.82 ns** |  **7.779 ns** | **0.426 ns** |  **55.39 ns** |  **56.24 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.26 ns | 44.860 ns | 2.459 ns | 198.32 ns | 203.03 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.28 ns | 15.970 ns | 0.875 ns |  59.42 ns |  61.17 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.31 ns |  0.201 ns | 0.011 ns |  34.30 ns |  34.32 ns | 0.0011 |      96 B |
