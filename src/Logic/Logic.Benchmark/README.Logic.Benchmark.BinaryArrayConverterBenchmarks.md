```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.82 ns** |   **2.810 ns** |  **0.154 ns** |  **17.65 ns** |  **17.93 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.56 ns |  12.957 ns |  0.710 ns |  61.89 ns |  63.30 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.91 ns |  54.939 ns |  3.011 ns |  20.09 ns |  25.39 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.61 ns |   4.662 ns |  0.256 ns |  10.46 ns |  10.91 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.64 ns |   2.393 ns |  0.131 ns |  18.54 ns |  18.79 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.91 ns |  13.353 ns |  0.732 ns |  70.25 ns |  71.69 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.18 ns |   2.082 ns |  0.114 ns |  19.10 ns |  19.31 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.18 ns |   0.488 ns |  0.027 ns |  10.15 ns |  10.20 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **65.48 ns** |  **23.361 ns** |  **1.281 ns** |  **64.02 ns** |  **66.42 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 190.66 ns |  10.836 ns |  0.594 ns | 190.09 ns | 191.28 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.04 ns |  28.803 ns |  1.579 ns |  57.73 ns |  60.79 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.92 ns |   8.228 ns |  0.451 ns |  34.49 ns |  35.39 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.82 ns |   4.108 ns |  0.225 ns |  53.57 ns |  54.01 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 220.44 ns | 490.361 ns | 26.878 ns | 202.98 ns | 251.39 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.77 ns |   7.112 ns |  0.390 ns |  59.42 ns |  60.19 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.66 ns |   0.497 ns |  0.027 ns |  33.63 ns |  33.68 ns | 0.0057 |      96 B |
