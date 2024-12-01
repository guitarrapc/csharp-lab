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
| **ToBinaryArrayInt**             | **1**      |  **18.68 ns** |  **3.101 ns** | **0.170 ns** |  **18.48 ns** |  **18.81 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.68 ns |  5.791 ns | 0.317 ns |  64.35 ns |  64.99 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.14 ns |  2.660 ns | 0.146 ns |  21.04 ns |  21.31 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  0.867 ns | 0.048 ns |  10.71 ns |  10.80 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.76 ns** | **19.603 ns** | **1.075 ns** |  **54.61 ns** |  **56.73 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.03 ns | 41.354 ns | 2.267 ns | 200.66 ns | 204.65 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.05 ns |  6.082 ns | 0.333 ns |  61.74 ns |  62.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.22 ns |  6.388 ns | 0.350 ns |  35.98 ns |  36.62 ns | 0.0011 |      96 B |
