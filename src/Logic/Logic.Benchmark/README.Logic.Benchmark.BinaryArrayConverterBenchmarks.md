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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **19.04 ns** |  **6.450 ns** | **0.354 ns** |  **18.63 ns** |  **19.28 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  66.43 ns | 21.166 ns | 1.160 ns |  65.48 ns |  67.72 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.79 ns |  7.225 ns | 0.396 ns |  21.33 ns |  22.06 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.84 ns |  2.068 ns | 0.113 ns |  10.77 ns |  10.97 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.53 ns |  3.388 ns | 0.186 ns |  18.40 ns |  18.74 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  72.80 ns | 54.632 ns | 2.995 ns |  70.83 ns |  76.24 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  20.37 ns |  3.176 ns | 0.174 ns |  20.20 ns |  20.55 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  11.40 ns |  2.191 ns | 0.120 ns |  11.26 ns |  11.50 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.56 ns** |  **9.051 ns** | **0.496 ns** |  **54.02 ns** |  **54.99 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 218.08 ns | 78.170 ns | 4.285 ns | 214.83 ns | 222.94 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  62.71 ns | 16.957 ns | 0.929 ns |  61.71 ns |  63.56 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  37.18 ns |  5.250 ns | 0.288 ns |  36.89 ns |  37.46 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.56 ns | 10.059 ns | 0.551 ns |  55.18 ns |  56.20 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 219.48 ns | 82.100 ns | 4.500 ns | 214.51 ns | 223.28 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  61.85 ns |  3.960 ns | 0.217 ns |  61.64 ns |  62.07 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.89 ns | 14.980 ns | 0.821 ns |  35.02 ns |  36.64 ns | 0.0057 |      96 B |
