```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min        | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|-----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.93 ns** |  **3.131 ns** | **0.172 ns** |  **17.734 ns** |  **18.04 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  64.28 ns |  4.979 ns | 0.273 ns |  63.992 ns |  64.54 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.42 ns |  2.238 ns | 0.123 ns |  20.313 ns |  20.55 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.04 ns |  1.107 ns | 0.061 ns |   9.995 ns |  10.10 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.13 ns |  9.420 ns | 0.516 ns |  16.641 ns |  17.67 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.45 ns |  9.046 ns | 0.496 ns |  67.987 ns |  68.97 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.89 ns |  5.454 ns | 0.299 ns |  18.551 ns |  19.10 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.23 ns |  1.727 ns | 0.095 ns |  10.160 ns |  10.34 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.06 ns** |  **7.972 ns** | **0.437 ns** |  **54.679 ns** |  **55.54 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 195.39 ns | 12.189 ns | 0.668 ns | 194.738 ns | 196.07 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.59 ns |  8.912 ns | 0.489 ns |  59.113 ns |  60.09 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.75 ns | 11.290 ns | 0.619 ns |  33.113 ns |  34.35 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.11 ns |  9.229 ns | 0.506 ns |  51.553 ns |  52.54 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 204.16 ns | 19.603 ns | 1.074 ns | 203.432 ns | 205.39 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  58.51 ns |  4.041 ns | 0.222 ns |  58.249 ns |  58.64 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.15 ns |  1.072 ns | 0.059 ns |  34.093 ns |  34.21 ns | 0.0057 |      96 B |
