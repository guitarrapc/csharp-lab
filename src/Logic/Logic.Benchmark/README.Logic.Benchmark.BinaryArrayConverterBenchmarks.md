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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.75 ns** |  **4.642 ns** | **0.254 ns** |  **18.46 ns** |  **18.94 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  64.79 ns | 15.365 ns | 0.842 ns |  63.85 ns |  65.46 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.37 ns |  1.533 ns | 0.084 ns |  20.30 ns |  20.47 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.85 ns |  1.966 ns | 0.108 ns |  10.72 ns |  10.91 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.16 ns |  3.239 ns | 0.178 ns |  17.97 ns |  18.33 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.38 ns |  9.932 ns | 0.544 ns |  69.87 ns |  70.95 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.31 ns |  4.329 ns | 0.237 ns |  19.05 ns |  19.52 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.45 ns |  1.506 ns | 0.083 ns |  10.37 ns |  10.53 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.69 ns** | **16.109 ns** | **0.883 ns** |  **55.68 ns** |  **57.28 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 200.16 ns | 10.978 ns | 0.602 ns | 199.75 ns | 200.85 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.46 ns |  4.380 ns | 0.240 ns |  59.21 ns |  59.69 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.32 ns | 20.716 ns | 1.136 ns |  33.59 ns |  35.63 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.61 ns |  6.104 ns | 0.335 ns |  54.26 ns |  54.93 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 212.63 ns | 22.027 ns | 1.207 ns | 211.68 ns | 213.99 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  61.72 ns |  2.697 ns | 0.148 ns |  61.60 ns |  61.88 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.62 ns |  3.602 ns | 0.197 ns |  34.44 ns |  34.83 ns | 0.0057 |      96 B |
