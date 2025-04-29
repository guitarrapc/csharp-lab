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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.65 ns** |  **8.217 ns** | **0.450 ns** |  **18.33 ns** |  **19.17 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  66.79 ns | 20.041 ns | 1.098 ns |  65.84 ns |  67.99 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.91 ns |  3.578 ns | 0.196 ns |  19.72 ns |  20.11 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.75 ns |  2.340 ns | 0.128 ns |  10.62 ns |  10.87 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.53 ns |  0.484 ns | 0.027 ns |  17.50 ns |  17.55 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  71.91 ns | 16.768 ns | 0.919 ns |  71.33 ns |  72.97 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  20.21 ns |  2.370 ns | 0.130 ns |  20.08 ns |  20.34 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.69 ns |  3.027 ns | 0.166 ns |  10.51 ns |  10.84 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.39 ns** |  **5.567 ns** | **0.305 ns** |  **54.04 ns** |  **54.60 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 199.01 ns | 10.347 ns | 0.567 ns | 198.41 ns | 199.54 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.49 ns |  7.146 ns | 0.392 ns |  60.09 ns |  60.87 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.78 ns |  8.929 ns | 0.489 ns |  33.36 ns |  34.32 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.58 ns |  9.356 ns | 0.513 ns |  54.99 ns |  55.90 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 216.49 ns | 43.187 ns | 2.367 ns | 213.81 ns | 218.28 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.12 ns | 13.235 ns | 0.725 ns |  59.29 ns |  60.62 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  36.03 ns |  7.134 ns | 0.391 ns |  35.77 ns |  36.48 ns | 0.0057 |      96 B |
