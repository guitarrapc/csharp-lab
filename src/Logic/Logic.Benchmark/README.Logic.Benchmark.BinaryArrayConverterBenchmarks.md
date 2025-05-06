```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **19.09 ns** |  **5.613 ns** | **0.308 ns** |  **18.77 ns** |  **19.38 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  67.74 ns | 14.870 ns | 0.815 ns |  67.16 ns |  68.67 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  22.25 ns |  1.878 ns | 0.103 ns |  22.17 ns |  22.37 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  11.51 ns |  1.666 ns | 0.091 ns |  11.40 ns |  11.57 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.72 ns | 11.664 ns | 0.639 ns |  18.21 ns |  19.44 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  73.45 ns | 15.069 ns | 0.826 ns |  72.88 ns |  74.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  21.12 ns |  1.896 ns | 0.104 ns |  21.01 ns |  21.22 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  11.51 ns |  1.524 ns | 0.084 ns |  11.43 ns |  11.59 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **57.18 ns** | **11.742 ns** | **0.644 ns** |  **56.45 ns** |  **57.67 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 207.06 ns |  1.762 ns | 0.097 ns | 206.97 ns | 207.16 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  65.57 ns | 12.362 ns | 0.678 ns |  64.85 ns |  66.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  38.11 ns |  5.638 ns | 0.309 ns |  37.76 ns |  38.33 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.50 ns |  7.886 ns | 0.432 ns |  57.02 ns |  57.86 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 219.19 ns | 11.100 ns | 0.608 ns | 218.58 ns | 219.80 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.31 ns |  6.085 ns | 0.334 ns |  62.02 ns |  62.68 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  37.12 ns |  3.610 ns | 0.198 ns |  36.92 ns |  37.32 ns | 0.0057 |      96 B |
