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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.28 ns** |  **1.802 ns** | **0.099 ns** |  **17.21 ns** |  **17.40 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.17 ns |  6.007 ns | 0.329 ns |  61.81 ns |  62.45 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.38 ns |  3.697 ns | 0.203 ns |  19.20 ns |  19.60 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.24 ns |  2.587 ns | 0.142 ns |  10.11 ns |  10.39 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.04 ns |  5.225 ns | 0.286 ns |  16.78 ns |  17.35 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.51 ns | 42.738 ns | 2.343 ns |  67.85 ns |  72.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.25 ns |  6.806 ns | 0.373 ns |  18.99 ns |  19.68 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.09 ns |  0.346 ns | 0.019 ns |  10.08 ns |  10.11 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **50.04 ns** |  **3.458 ns** | **0.190 ns** |  **49.91 ns** |  **50.26 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 192.45 ns | 65.327 ns | 3.581 ns | 188.52 ns | 195.52 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.15 ns | 13.185 ns | 0.723 ns |  59.36 ns |  60.76 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  32.79 ns | 14.062 ns | 0.771 ns |  31.98 ns |  33.51 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.30 ns |  7.842 ns | 0.430 ns |  52.84 ns |  53.70 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 204.32 ns | 27.255 ns | 1.494 ns | 203.16 ns | 206.01 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.18 ns |  0.829 ns | 0.045 ns |  59.14 ns |  59.23 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.26 ns |  3.465 ns | 0.190 ns |  33.04 ns |  33.39 ns | 0.0057 |      96 B |
