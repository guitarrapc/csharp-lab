```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **19.00 ns** | **10.282 ns** | **0.564 ns** |  **18.64 ns** |  **19.65 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  69.19 ns | 26.381 ns | 1.446 ns |  67.53 ns |  70.19 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.76 ns |  5.820 ns | 0.319 ns |  21.50 ns |  22.12 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  12.12 ns |  8.198 ns | 0.449 ns |  11.66 ns |  12.56 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.15 ns |  4.977 ns | 0.273 ns |  17.98 ns |  18.47 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  71.57 ns |  9.601 ns | 0.526 ns |  71.25 ns |  72.17 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  21.77 ns |  3.559 ns | 0.195 ns |  21.55 ns |  21.90 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  12.50 ns |  2.117 ns | 0.116 ns |  12.41 ns |  12.63 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **58.68 ns** | **17.748 ns** | **0.973 ns** |  **57.89 ns** |  **59.77 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 211.29 ns | 17.305 ns | 0.949 ns | 210.20 ns | 211.94 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  64.59 ns | 15.470 ns | 0.848 ns |  63.76 ns |  65.46 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  38.39 ns |  1.106 ns | 0.061 ns |  38.33 ns |  38.46 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.26 ns |  5.983 ns | 0.328 ns |  57.06 ns |  57.64 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 221.22 ns | 21.354 ns | 1.170 ns | 219.89 ns | 222.12 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  64.91 ns | 15.456 ns | 0.847 ns |  63.94 ns |  65.53 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  39.03 ns | 16.249 ns | 0.891 ns |  38.20 ns |  39.97 ns | 0.0057 |      96 B |
