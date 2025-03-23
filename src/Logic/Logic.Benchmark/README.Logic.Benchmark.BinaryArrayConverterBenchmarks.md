```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.31 ns** |  **6.721 ns** | **0.368 ns** |  **17.94 ns** |  **18.68 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  64.12 ns |  5.941 ns | 0.326 ns |  63.75 ns |  64.35 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.87 ns |  3.655 ns | 0.200 ns |  20.72 ns |  21.10 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.65 ns |  1.485 ns | 0.081 ns |  10.58 ns |  10.74 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.12 ns |  3.276 ns | 0.180 ns |  17.91 ns |  18.22 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.01 ns |  7.339 ns | 0.402 ns |  69.70 ns |  70.46 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.55 ns |  2.099 ns | 0.115 ns |  19.42 ns |  19.64 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.42 ns |  2.092 ns | 0.115 ns |  10.30 ns |  10.53 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **58.40 ns** |  **3.678 ns** | **0.202 ns** |  **58.17 ns** |  **58.56 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 199.54 ns | 11.252 ns | 0.617 ns | 198.88 ns | 200.11 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.44 ns | 16.874 ns | 0.925 ns |  60.56 ns |  62.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.12 ns |  6.273 ns | 0.344 ns |  32.72 ns |  33.36 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.29 ns | 13.058 ns | 0.716 ns |  54.58 ns |  56.01 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 210.92 ns | 49.696 ns | 2.724 ns | 207.78 ns | 212.53 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.84 ns | 11.080 ns | 0.607 ns |  59.17 ns |  60.36 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.88 ns |  1.012 ns | 0.055 ns |  33.84 ns |  33.94 ns | 0.0057 |      96 B |
