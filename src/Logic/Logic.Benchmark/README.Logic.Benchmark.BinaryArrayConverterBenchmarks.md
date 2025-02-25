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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **19.19 ns** |  **6.604 ns** | **0.362 ns** |  **18.87 ns** |  **19.59 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  68.92 ns | 20.785 ns | 1.139 ns |  68.24 ns |  70.23 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.69 ns |  8.326 ns | 0.456 ns |  20.36 ns |  21.21 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  11.07 ns |  1.920 ns | 0.105 ns |  10.95 ns |  11.15 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.78 ns |  2.813 ns | 0.154 ns |  17.62 ns |  17.92 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  71.44 ns |  9.342 ns | 0.512 ns |  70.85 ns |  71.80 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.28 ns |  6.631 ns | 0.363 ns |  19.03 ns |  19.70 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.87 ns |  3.104 ns | 0.170 ns |  10.69 ns |  11.03 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **52.98 ns** |  **7.038 ns** | **0.386 ns** |  **52.58 ns** |  **53.35 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 201.83 ns | 23.840 ns | 1.307 ns | 200.90 ns | 203.32 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.09 ns | 32.604 ns | 1.787 ns |  59.90 ns |  63.15 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  36.02 ns |  5.965 ns | 0.327 ns |  35.73 ns |  36.37 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.17 ns |  3.281 ns | 0.180 ns |  57.05 ns |  57.37 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 217.03 ns | 30.723 ns | 1.684 ns | 215.92 ns | 218.97 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.03 ns |  3.476 ns | 0.191 ns |  61.85 ns |  62.23 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  36.58 ns |  4.030 ns | 0.221 ns |  36.34 ns |  36.78 ns | 0.0057 |      96 B |
