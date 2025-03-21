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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.08 ns** |  **4.341 ns** | **0.238 ns** |  **16.94 ns** |  **17.35 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  68.73 ns |  5.523 ns | 0.303 ns |  68.44 ns |  69.04 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.66 ns |  2.198 ns | 0.120 ns |  20.53 ns |  20.76 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.73 ns |  1.888 ns | 0.103 ns |  10.64 ns |  10.84 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.63 ns |  1.619 ns | 0.089 ns |  17.57 ns |  17.74 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.57 ns | 11.253 ns | 0.617 ns |  70.13 ns |  71.28 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.58 ns |  5.537 ns | 0.303 ns |  19.39 ns |  19.93 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.79 ns |  2.684 ns | 0.147 ns |  10.65 ns |  10.94 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.19 ns** |  **6.892 ns** | **0.378 ns** |  **53.76 ns** |  **54.49 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 197.61 ns | 15.017 ns | 0.823 ns | 196.67 ns | 198.14 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  62.71 ns | 28.815 ns | 1.579 ns |  60.92 ns |  63.90 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  35.26 ns | 16.414 ns | 0.900 ns |  34.38 ns |  36.17 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.54 ns | 10.184 ns | 0.558 ns |  53.93 ns |  55.01 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 219.66 ns | 30.809 ns | 1.689 ns | 217.83 ns | 221.15 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  61.26 ns | 14.804 ns | 0.811 ns |  60.70 ns |  62.19 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.90 ns |  8.304 ns | 0.455 ns |  35.49 ns |  36.39 ns | 0.0057 |      96 B |
