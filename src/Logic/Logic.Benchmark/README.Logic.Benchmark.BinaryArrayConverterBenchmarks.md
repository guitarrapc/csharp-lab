```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min        | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|-----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.13 ns** |  **2.345 ns** | **0.129 ns** |  **18.011 ns** |  **18.27 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.75 ns | 11.893 ns | 0.652 ns |  63.002 ns |  64.15 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.49 ns |  1.615 ns | 0.089 ns |  20.416 ns |  20.59 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.01 ns |  1.571 ns | 0.086 ns |   9.957 ns |  10.11 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.17 ns |  2.667 ns | 0.146 ns |  17.005 ns |  17.29 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.90 ns |  6.924 ns | 0.380 ns |  68.527 ns |  69.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.99 ns |  1.148 ns | 0.063 ns |  19.940 ns |  20.06 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.46 ns |  0.272 ns | 0.015 ns |  10.444 ns |  10.47 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.94 ns** |  **7.102 ns** | **0.389 ns** |  **54.496 ns** |  **55.23 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 199.50 ns |  6.966 ns | 0.382 ns | 199.067 ns | 199.80 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  57.95 ns |  3.999 ns | 0.219 ns |  57.699 ns |  58.11 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.07 ns |  3.684 ns | 0.202 ns |  33.837 ns |  34.22 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.16 ns |  3.612 ns | 0.198 ns |  53.931 ns |  54.29 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 210.61 ns | 32.768 ns | 1.796 ns | 208.692 ns | 212.25 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.79 ns | 11.113 ns | 0.609 ns |  60.123 ns |  61.32 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.90 ns | 11.030 ns | 0.605 ns |  33.500 ns |  34.59 ns | 0.0057 |      96 B |
