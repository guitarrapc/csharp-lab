```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **16.99 ns** |  **5.424 ns** | **0.297 ns** |  **16.65 ns** |  **17.21 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.67 ns |  6.126 ns | 0.336 ns |  62.44 ns |  63.06 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.63 ns |  7.023 ns | 0.385 ns |  20.24 ns |  21.01 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.15 ns |  1.310 ns | 0.072 ns |  10.06 ns |  10.20 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.33 ns |  6.531 ns | 0.358 ns |  16.93 ns |  17.62 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.26 ns |  2.141 ns | 0.117 ns |  68.16 ns |  68.39 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.62 ns |  1.480 ns | 0.081 ns |  19.56 ns |  19.71 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.67 ns |  5.283 ns | 0.290 ns |  10.45 ns |  11.00 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **58.62 ns** |  **8.059 ns** | **0.442 ns** |  **58.12 ns** |  **58.97 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 194.73 ns | 20.989 ns | 1.150 ns | 193.41 ns | 195.47 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  62.34 ns | 13.279 ns | 0.728 ns |  61.53 ns |  62.93 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.14 ns |  3.401 ns | 0.186 ns |  33.97 ns |  34.34 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  56.30 ns | 22.133 ns | 1.213 ns |  54.95 ns |  57.29 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 213.12 ns |  8.906 ns | 0.488 ns | 212.56 ns | 213.45 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.08 ns | 27.853 ns | 1.527 ns |  60.81 ns |  63.78 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.21 ns |  6.980 ns | 0.383 ns |  33.92 ns |  34.64 ns | 0.0057 |      96 B |
