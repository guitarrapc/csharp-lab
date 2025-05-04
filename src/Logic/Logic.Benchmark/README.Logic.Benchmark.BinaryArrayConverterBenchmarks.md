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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.25 ns** |  **2.821 ns** | **0.155 ns** |  **18.11 ns** |  **18.41 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.09 ns | 28.756 ns | 1.576 ns |  63.78 ns |  66.84 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.15 ns |  2.788 ns | 0.153 ns |  20.03 ns |  20.32 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.62 ns |  5.876 ns | 0.322 ns |  10.43 ns |  10.99 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.04 ns |  2.004 ns | 0.110 ns |  16.91 ns |  17.11 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.41 ns |  6.336 ns | 0.347 ns |  68.02 ns |  68.69 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  20.19 ns |  0.871 ns | 0.048 ns |  20.14 ns |  20.22 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.56 ns |  2.219 ns | 0.122 ns |  10.48 ns |  10.70 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.15 ns** |  **6.925 ns** | **0.380 ns** |  **54.74 ns** |  **55.49 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 195.59 ns | 59.029 ns | 3.236 ns | 193.43 ns | 199.31 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  58.62 ns | 18.727 ns | 1.027 ns |  57.43 ns |  59.21 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.85 ns |  7.200 ns | 0.395 ns |  33.43 ns |  34.21 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  56.35 ns |  2.297 ns | 0.126 ns |  56.27 ns |  56.49 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 213.32 ns | 37.365 ns | 2.048 ns | 211.18 ns | 215.27 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.73 ns |  9.398 ns | 0.515 ns |  60.34 ns |  61.31 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.10 ns |  9.775 ns | 0.536 ns |  34.76 ns |  35.72 ns | 0.0057 |      96 B |
