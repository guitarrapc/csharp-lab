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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.10 ns** |  **6.458 ns** | **0.354 ns** |  **17.87 ns** |  **18.50 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.81 ns |  5.961 ns | 0.327 ns |  62.43 ns |  63.02 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.70 ns |  3.490 ns | 0.191 ns |  19.53 ns |  19.91 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.22 ns |  3.238 ns | 0.177 ns |  10.07 ns |  10.41 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.99 ns |  1.797 ns | 0.098 ns |  16.91 ns |  17.10 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  69.04 ns | 17.155 ns | 0.940 ns |  68.29 ns |  70.10 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.71 ns |  2.857 ns | 0.157 ns |  18.54 ns |  18.86 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.35 ns |  1.754 ns | 0.096 ns |  10.25 ns |  10.44 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **57.54 ns** |  **7.815 ns** | **0.428 ns** |  **57.22 ns** |  **58.03 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 196.22 ns | 13.755 ns | 0.754 ns | 195.77 ns | 197.09 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.49 ns | 10.489 ns | 0.575 ns |  58.98 ns |  60.11 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.16 ns |  5.227 ns | 0.286 ns |  33.95 ns |  34.48 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.98 ns |  4.505 ns | 0.247 ns |  52.76 ns |  53.25 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 206.21 ns | 15.401 ns | 0.844 ns | 205.29 ns | 206.95 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.75 ns |  3.370 ns | 0.185 ns |  59.54 ns |  59.88 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.38 ns |  2.563 ns | 0.140 ns |  34.28 ns |  34.54 ns | 0.0057 |      96 B |
