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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.84 ns** |  **3.702 ns** | **0.203 ns** |  **17.66 ns** |  **18.06 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.91 ns | 27.714 ns | 1.519 ns |  62.89 ns |  65.66 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.99 ns |  9.527 ns | 0.522 ns |  20.57 ns |  21.57 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.29 ns |  3.310 ns | 0.181 ns |  10.09 ns |  10.45 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.10 ns |  1.091 ns | 0.060 ns |  17.05 ns |  17.16 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.10 ns |  6.352 ns | 0.348 ns |  69.72 ns |  70.41 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.12 ns |  3.274 ns | 0.179 ns |  18.96 ns |  19.32 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.34 ns |  1.998 ns | 0.110 ns |  10.22 ns |  10.44 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **53.88 ns** |  **5.583 ns** | **0.306 ns** |  **53.53 ns** |  **54.08 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 190.41 ns | 18.130 ns | 0.994 ns | 189.62 ns | 191.52 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.14 ns |  5.614 ns | 0.308 ns |  58.82 ns |  59.44 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.81 ns | 14.100 ns | 0.773 ns |  34.01 ns |  35.55 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.01 ns |  2.107 ns | 0.115 ns |  54.93 ns |  55.14 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 202.88 ns | 43.395 ns | 2.379 ns | 200.93 ns | 205.53 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  58.90 ns |  6.503 ns | 0.356 ns |  58.52 ns |  59.22 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.84 ns |  3.088 ns | 0.169 ns |  33.71 ns |  34.03 ns | 0.0057 |      96 B |
