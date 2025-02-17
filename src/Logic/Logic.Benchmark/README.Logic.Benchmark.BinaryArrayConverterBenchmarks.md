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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.34 ns** |  **3.685 ns** | **0.202 ns** |  **17.20 ns** |  **17.57 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.20 ns |  3.464 ns | 0.190 ns |  61.99 ns |  62.36 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.43 ns |  2.238 ns | 0.123 ns |  19.32 ns |  19.56 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.04 ns |  0.366 ns | 0.020 ns |  10.02 ns |  10.06 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.20 ns | 17.183 ns | 0.942 ns |  17.61 ns |  19.29 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  69.20 ns | 17.308 ns | 0.949 ns |  68.61 ns |  70.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.15 ns |  0.942 ns | 0.052 ns |  19.10 ns |  19.20 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.70 ns |  2.913 ns | 0.160 ns |  10.61 ns |  10.88 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.39 ns** | **12.665 ns** | **0.694 ns** |  **53.62 ns** |  **54.97 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 198.94 ns | 27.848 ns | 1.526 ns | 197.50 ns | 200.54 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.96 ns | 11.703 ns | 0.641 ns |  60.52 ns |  61.69 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  35.82 ns | 11.444 ns | 0.627 ns |  35.13 ns |  36.34 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.86 ns |  4.429 ns | 0.243 ns |  55.62 ns |  56.10 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 213.74 ns | 23.553 ns | 1.291 ns | 212.30 ns | 214.79 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  61.80 ns | 13.061 ns | 0.716 ns |  61.13 ns |  62.56 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  36.57 ns | 12.616 ns | 0.692 ns |  35.95 ns |  37.31 ns | 0.0057 |      96 B |
