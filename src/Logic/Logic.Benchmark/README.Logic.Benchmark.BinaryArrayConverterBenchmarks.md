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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.79 ns** |  **3.861 ns** | **0.212 ns** |  **17.56 ns** |  **17.97 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.79 ns | 15.650 ns | 0.858 ns |  64.80 ns |  66.30 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.01 ns |  2.151 ns | 0.118 ns |  19.88 ns |  20.11 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  14.49 ns |  0.337 ns | 0.018 ns |  14.47 ns |  14.50 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.67 ns |  1.913 ns | 0.105 ns |  16.57 ns |  16.78 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  66.94 ns |  4.289 ns | 0.235 ns |  66.76 ns |  67.21 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.35 ns |  2.499 ns | 0.137 ns |  18.27 ns |  18.51 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.13 ns |  0.446 ns | 0.024 ns |  10.10 ns |  10.14 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **50.38 ns** |  **7.354 ns** | **0.403 ns** |  **49.97 ns** |  **50.77 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 198.66 ns |  8.689 ns | 0.476 ns | 198.13 ns | 199.04 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  57.26 ns |  6.726 ns | 0.369 ns |  56.87 ns |  57.60 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  32.32 ns |  6.286 ns | 0.345 ns |  31.99 ns |  32.68 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.09 ns |  5.934 ns | 0.325 ns |  51.72 ns |  52.28 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 207.33 ns | 67.197 ns | 3.683 ns | 204.53 ns | 211.50 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.26 ns |  7.027 ns | 0.385 ns |  58.94 ns |  59.68 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.43 ns |  3.131 ns | 0.172 ns |  33.29 ns |  33.62 ns | 0.0057 |      96 B |
