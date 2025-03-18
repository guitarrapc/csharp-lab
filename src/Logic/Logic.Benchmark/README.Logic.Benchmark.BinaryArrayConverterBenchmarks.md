```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.43 ns** |  **5.484 ns** | **0.301 ns** |  **18.09 ns** |  **18.65 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.40 ns | 10.358 ns | 0.568 ns |  62.75 ns |  63.80 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.12 ns |  5.245 ns | 0.287 ns |  19.83 ns |  20.40 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.41 ns |  1.858 ns | 0.102 ns |  10.29 ns |  10.49 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.24 ns |  6.989 ns | 0.383 ns |  16.87 ns |  17.63 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.00 ns |  5.560 ns | 0.305 ns |  67.74 ns |  68.34 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.88 ns |  4.196 ns | 0.230 ns |  18.62 ns |  19.06 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.38 ns |  0.927 ns | 0.051 ns |  10.34 ns |  10.44 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.48 ns** |  **9.766 ns** | **0.535 ns** |  **53.89 ns** |  **54.94 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.46 ns |  1.393 ns | 0.076 ns | 193.37 ns | 193.51 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.70 ns | 10.879 ns | 0.596 ns |  59.14 ns |  60.33 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.12 ns |  4.451 ns | 0.244 ns |  33.90 ns |  34.38 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.07 ns |  6.845 ns | 0.375 ns |  54.68 ns |  55.42 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 209.00 ns | 13.857 ns | 0.760 ns | 208.28 ns | 209.79 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.35 ns |  4.536 ns | 0.249 ns |  60.10 ns |  60.59 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.77 ns |  5.106 ns | 0.280 ns |  34.45 ns |  34.96 ns | 0.0057 |      96 B |
