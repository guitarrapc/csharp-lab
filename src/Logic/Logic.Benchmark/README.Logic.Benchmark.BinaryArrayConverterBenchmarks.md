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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.08 ns** |  **1.649 ns** | **0.090 ns** |  **18.03 ns** |  **18.19 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.09 ns |  7.980 ns | 0.437 ns |  61.67 ns |  62.54 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.52 ns |  2.991 ns | 0.164 ns |  19.41 ns |  19.70 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.16 ns |  1.943 ns | 0.107 ns |  10.05 ns |  10.26 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.51 ns |  3.413 ns | 0.187 ns |  17.30 ns |  17.63 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  67.51 ns |  2.928 ns | 0.160 ns |  67.33 ns |  67.64 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.61 ns |  1.145 ns | 0.063 ns |  18.56 ns |  18.68 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.18 ns |  0.490 ns | 0.027 ns |  10.15 ns |  10.20 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **53.34 ns** | **10.514 ns** | **0.576 ns** |  **52.81 ns** |  **53.96 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 198.16 ns | 19.771 ns | 1.084 ns | 197.23 ns | 199.35 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  58.28 ns |  9.805 ns | 0.537 ns |  57.75 ns |  58.83 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  37.63 ns | 10.291 ns | 0.564 ns |  37.24 ns |  38.27 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.58 ns |  7.494 ns | 0.411 ns |  53.11 ns |  53.87 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 212.81 ns | 97.927 ns | 5.368 ns | 206.64 ns | 216.43 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.90 ns | 15.749 ns | 0.863 ns |  58.92 ns |  60.54 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.05 ns |  1.328 ns | 0.073 ns |  33.99 ns |  34.13 ns | 0.0057 |      96 B |
