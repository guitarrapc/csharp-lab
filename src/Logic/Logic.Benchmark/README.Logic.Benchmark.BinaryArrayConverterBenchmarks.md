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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.33 ns** |  **3.603 ns** | **0.198 ns** |  **17.10 ns** |  **17.45 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  64.35 ns | 23.050 ns | 1.263 ns |  63.54 ns |  65.80 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.95 ns |  1.634 ns | 0.090 ns |  20.84 ns |  21.01 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.13 ns |  0.684 ns | 0.038 ns |  10.09 ns |  10.16 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.28 ns |  3.832 ns | 0.210 ns |  17.08 ns |  17.50 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.53 ns |  3.598 ns | 0.197 ns |  68.30 ns |  68.64 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.84 ns |  2.258 ns | 0.124 ns |  18.76 ns |  18.98 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.36 ns |  2.128 ns | 0.117 ns |  10.29 ns |  10.50 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **49.56 ns** |  **9.094 ns** | **0.498 ns** |  **49.03 ns** |  **50.01 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.88 ns | 92.907 ns | 5.093 ns | 190.81 ns | 199.76 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.57 ns |  5.147 ns | 0.282 ns |  61.38 ns |  61.89 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.22 ns |  4.950 ns | 0.271 ns |  33.99 ns |  34.52 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.54 ns |  4.171 ns | 0.229 ns |  53.28 ns |  53.72 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 206.89 ns |  9.109 ns | 0.499 ns | 206.39 ns | 207.39 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  57.87 ns |  2.017 ns | 0.111 ns |  57.75 ns |  57.97 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.05 ns |  5.721 ns | 0.314 ns |  33.85 ns |  34.41 ns | 0.0057 |      96 B |
