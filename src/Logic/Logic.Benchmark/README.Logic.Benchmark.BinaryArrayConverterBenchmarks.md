```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **20.39 ns** |  **6.984 ns** | **0.383 ns** |  **20.06 ns** |  **20.81 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  64.52 ns |  9.058 ns | 0.497 ns |  63.95 ns |  64.86 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.27 ns |  5.044 ns | 0.276 ns |  20.95 ns |  21.47 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.80 ns |  2.340 ns | 0.128 ns |  10.66 ns |  10.90 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.74 ns |  5.692 ns | 0.312 ns |  17.47 ns |  18.08 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  72.05 ns | 30.142 ns | 1.652 ns |  70.43 ns |  73.74 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  20.25 ns |  6.377 ns | 0.350 ns |  19.91 ns |  20.61 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  11.29 ns |  2.739 ns | 0.150 ns |  11.14 ns |  11.44 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **59.89 ns** |  **4.883 ns** | **0.268 ns** |  **59.59 ns** |  **60.08 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 215.37 ns | 14.838 ns | 0.813 ns | 214.45 ns | 216.00 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  62.48 ns | 14.058 ns | 0.771 ns |  61.77 ns |  63.30 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  36.24 ns | 17.236 ns | 0.945 ns |  35.17 ns |  36.97 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.05 ns |  0.490 ns | 0.027 ns |  57.02 ns |  57.08 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 215.66 ns |  5.386 ns | 0.295 ns | 215.44 ns | 216.00 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.43 ns | 13.458 ns | 0.738 ns |  61.81 ns |  63.24 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  36.92 ns | 21.334 ns | 1.169 ns |  36.10 ns |  38.26 ns | 0.0057 |      96 B |
