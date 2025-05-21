```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.80 ns** | **15.596 ns** | **0.855 ns** |  **17.28 ns** |  **18.79 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.16 ns |  4.371 ns | 0.240 ns |  62.00 ns |  62.43 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.78 ns |  2.784 ns | 0.153 ns |  19.66 ns |  19.95 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.21 ns |  0.458 ns | 0.025 ns |  10.19 ns |  10.24 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.77 ns |  3.331 ns | 0.183 ns |  16.56 ns |  16.90 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  67.61 ns |  1.030 ns | 0.056 ns |  67.57 ns |  67.68 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.52 ns |  1.455 ns | 0.080 ns |  18.45 ns |  18.61 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.10 ns |  1.270 ns | 0.070 ns |  10.06 ns |  10.18 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **53.85 ns** |  **6.156 ns** | **0.337 ns** |  **53.60 ns** |  **54.23 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 191.48 ns |  4.350 ns | 0.238 ns | 191.20 ns | 191.62 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  57.90 ns |  6.575 ns | 0.360 ns |  57.62 ns |  58.31 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  32.78 ns |  7.662 ns | 0.420 ns |  32.43 ns |  33.24 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.72 ns | 18.005 ns | 0.987 ns |  55.03 ns |  56.85 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 206.78 ns |  6.744 ns | 0.370 ns | 206.47 ns | 207.19 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.14 ns |  3.513 ns | 0.193 ns |  58.93 ns |  59.31 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.67 ns |  0.668 ns | 0.037 ns |  33.63 ns |  33.69 ns | 0.0057 |      96 B |
