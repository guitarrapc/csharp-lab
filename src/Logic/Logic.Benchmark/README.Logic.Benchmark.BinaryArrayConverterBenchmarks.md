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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.44 ns** |  **8.225 ns** | **0.451 ns** |  **18.00 ns** |  **18.90 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.77 ns | 16.325 ns | 0.895 ns |  63.10 ns |  64.79 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  18.70 ns |  0.562 ns | 0.031 ns |  18.67 ns |  18.73 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.15 ns |  1.633 ns | 0.090 ns |  10.08 ns |  10.25 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.47 ns |  9.856 ns | 0.540 ns |  16.85 ns |  17.85 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.56 ns |  2.994 ns | 0.164 ns |  68.46 ns |  68.75 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.67 ns |  2.523 ns | 0.138 ns |  18.52 ns |  18.77 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.34 ns |  1.139 ns | 0.062 ns |  10.28 ns |  10.41 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.59 ns** |  **9.787 ns** | **0.536 ns** |  **56.15 ns** |  **57.19 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 194.50 ns | 25.002 ns | 1.370 ns | 193.33 ns | 196.01 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.00 ns |  2.768 ns | 0.152 ns |  59.87 ns |  60.16 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  32.84 ns |  1.568 ns | 0.086 ns |  32.74 ns |  32.91 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  57.10 ns | 17.131 ns | 0.939 ns |  56.48 ns |  58.18 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 209.87 ns | 87.994 ns | 4.823 ns | 206.95 ns | 215.44 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.91 ns |  0.477 ns | 0.026 ns |  59.89 ns |  59.94 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.91 ns |  3.533 ns | 0.194 ns |  33.79 ns |  34.13 ns | 0.0057 |      96 B |
