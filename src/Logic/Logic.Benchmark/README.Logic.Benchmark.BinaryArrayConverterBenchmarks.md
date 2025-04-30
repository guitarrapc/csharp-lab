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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.20 ns** |  **0.867 ns** | **0.048 ns** |  **18.15 ns** |  **18.24 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  67.93 ns |  6.357 ns | 0.348 ns |  67.60 ns |  68.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.64 ns |  5.592 ns | 0.307 ns |  21.29 ns |  21.83 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  11.37 ns |  1.756 ns | 0.096 ns |  11.31 ns |  11.48 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  19.47 ns |  3.671 ns | 0.201 ns |  19.25 ns |  19.64 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  71.09 ns |  8.507 ns | 0.466 ns |  70.71 ns |  71.61 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.90 ns |  1.991 ns | 0.109 ns |  19.78 ns |  19.99 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  12.06 ns |  1.555 ns | 0.085 ns |  11.98 ns |  12.15 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.23 ns** | **15.836 ns** | **0.868 ns** |  **54.52 ns** |  **56.20 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 205.50 ns | 18.967 ns | 1.040 ns | 204.43 ns | 206.51 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  62.97 ns |  8.915 ns | 0.489 ns |  62.51 ns |  63.48 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  37.11 ns |  0.628 ns | 0.034 ns |  37.08 ns |  37.14 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.47 ns |  8.257 ns | 0.453 ns |  57.12 ns |  57.98 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 215.99 ns | 48.818 ns | 2.676 ns | 213.62 ns | 218.89 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.82 ns |  4.018 ns | 0.220 ns |  62.57 ns |  62.98 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  36.18 ns |  4.856 ns | 0.266 ns |  35.95 ns |  36.47 ns | 0.0057 |      96 B |
