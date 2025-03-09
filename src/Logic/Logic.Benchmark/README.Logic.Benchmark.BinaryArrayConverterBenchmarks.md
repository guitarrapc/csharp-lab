```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.86 ns** |  **1.692 ns** | **0.093 ns** |  **17.79 ns** |  **17.97 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.87 ns | 11.313 ns | 0.620 ns |  63.45 ns |  64.58 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.26 ns |  0.979 ns | 0.054 ns |  19.21 ns |  19.32 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.10 ns |  1.038 ns | 0.057 ns |  10.06 ns |  10.16 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.91 ns |  7.353 ns | 0.403 ns |  16.45 ns |  17.18 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  67.22 ns |  4.338 ns | 0.238 ns |  66.95 ns |  67.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.68 ns |  6.569 ns | 0.360 ns |  18.39 ns |  19.08 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.17 ns |  2.028 ns | 0.111 ns |  10.09 ns |  10.30 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **52.38 ns** |  **9.845 ns** | **0.540 ns** |  **51.86 ns** |  **52.94 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.02 ns |  2.573 ns | 0.141 ns | 192.87 ns | 193.15 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.13 ns |  7.320 ns | 0.401 ns |  58.73 ns |  59.53 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.12 ns |  8.711 ns | 0.477 ns |  33.69 ns |  34.63 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.48 ns |  3.854 ns | 0.211 ns |  52.30 ns |  52.71 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 214.53 ns |  3.785 ns | 0.207 ns | 214.32 ns | 214.73 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.18 ns | 11.790 ns | 0.646 ns |  58.74 ns |  59.92 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.01 ns |  4.036 ns | 0.221 ns |  33.82 ns |  34.25 ns | 0.0057 |      96 B |
