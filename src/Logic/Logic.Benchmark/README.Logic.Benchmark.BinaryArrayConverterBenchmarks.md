```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.44 ns** |  **2.332 ns** | **0.128 ns** |  **18.34 ns** |  **18.58 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  68.26 ns | 39.368 ns | 2.158 ns |  66.91 ns |  70.75 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.07 ns |  1.099 ns | 0.060 ns |  20.01 ns |  20.13 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  11.13 ns |  2.398 ns | 0.131 ns |  11.04 ns |  11.28 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.16 ns |  3.440 ns | 0.189 ns |  17.99 ns |  18.36 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  72.06 ns |  9.921 ns | 0.544 ns |  71.55 ns |  72.63 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.59 ns |  3.448 ns | 0.189 ns |  19.47 ns |  19.81 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.75 ns |  1.782 ns | 0.098 ns |  10.65 ns |  10.85 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.27 ns** |  **6.795 ns** | **0.372 ns** |  **53.84 ns** |  **54.51 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 207.70 ns | 14.614 ns | 0.801 ns | 206.78 ns | 208.28 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  66.87 ns | 13.802 ns | 0.757 ns |  66.00 ns |  67.42 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  35.50 ns |  8.355 ns | 0.458 ns |  35.08 ns |  35.99 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.37 ns | 13.437 ns | 0.737 ns |  54.80 ns |  56.20 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 217.77 ns |  5.648 ns | 0.310 ns | 217.42 ns | 218.02 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  62.82 ns |  0.111 ns | 0.006 ns |  62.81 ns |  62.82 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  37.44 ns |  2.380 ns | 0.130 ns |  37.31 ns |  37.57 ns | 0.0057 |      96 B |
