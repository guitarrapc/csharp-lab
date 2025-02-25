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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.84 ns** |  **2.004 ns** | **0.110 ns** |  **17.74 ns** |  **17.96 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.00 ns |  3.209 ns | 0.176 ns |  64.80 ns |  65.13 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.55 ns |  2.787 ns | 0.153 ns |  20.39 ns |  20.69 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.28 ns |  2.172 ns | 0.119 ns |  10.17 ns |  10.40 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.94 ns |  1.015 ns | 0.056 ns |  16.88 ns |  16.98 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.23 ns |  7.052 ns | 0.387 ns |  67.91 ns |  68.66 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.50 ns |  7.309 ns | 0.401 ns |  19.06 ns |  19.85 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.53 ns |  3.017 ns | 0.165 ns |  10.35 ns |  10.68 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.69 ns** |  **4.768 ns** | **0.261 ns** |  **54.43 ns** |  **54.95 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 195.38 ns | 20.097 ns | 1.102 ns | 194.46 ns | 196.60 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.33 ns |  9.451 ns | 0.518 ns |  60.73 ns |  61.65 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.77 ns | 10.811 ns | 0.593 ns |  33.09 ns |  34.14 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.65 ns |  7.176 ns | 0.393 ns |  54.21 ns |  54.96 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 208.13 ns | 20.428 ns | 1.120 ns | 207.41 ns | 209.42 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.73 ns |  4.897 ns | 0.268 ns |  60.46 ns |  61.00 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.51 ns |  5.049 ns | 0.277 ns |  34.30 ns |  34.82 ns | 0.0057 |      96 B |
