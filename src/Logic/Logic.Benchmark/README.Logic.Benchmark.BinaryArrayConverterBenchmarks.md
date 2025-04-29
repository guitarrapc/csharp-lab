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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.14 ns** |  **3.772 ns** | **0.207 ns** |  **17.90 ns** |  **18.28 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.39 ns |  9.348 ns | 0.512 ns |  61.81 ns |  62.79 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.72 ns |  3.916 ns | 0.215 ns |  19.54 ns |  19.95 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.28 ns |  2.360 ns | 0.129 ns |  10.13 ns |  10.38 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.38 ns |  2.079 ns | 0.114 ns |  17.25 ns |  17.47 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.46 ns | 10.743 ns | 0.589 ns |  69.85 ns |  71.03 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.72 ns |  1.965 ns | 0.108 ns |  19.60 ns |  19.80 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.56 ns |  1.812 ns | 0.099 ns |  10.48 ns |  10.67 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **57.36 ns** | **16.285 ns** | **0.893 ns** |  **56.37 ns** |  **58.10 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 200.48 ns | 44.423 ns | 2.435 ns | 198.90 ns | 203.29 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.37 ns |  7.862 ns | 0.431 ns |  59.00 ns |  59.85 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.21 ns |  5.295 ns | 0.290 ns |  32.92 ns |  33.50 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  56.27 ns |  9.981 ns | 0.547 ns |  55.86 ns |  56.89 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 219.86 ns | 89.576 ns | 4.910 ns | 214.80 ns | 224.61 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.95 ns |  4.828 ns | 0.265 ns |  60.66 ns |  61.18 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.23 ns |  7.014 ns | 0.384 ns |  34.79 ns |  35.49 ns | 0.0057 |      96 B |
