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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.02 ns** |  **4.215 ns** | **0.231 ns** |  **16.85 ns** |  **17.28 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.94 ns | 11.060 ns | 0.606 ns |  62.30 ns |  63.50 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.90 ns |  4.775 ns | 0.262 ns |  19.65 ns |  20.17 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.09 ns |  1.164 ns | 0.064 ns |  10.02 ns |  10.15 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.90 ns |  3.471 ns | 0.190 ns |  16.77 ns |  17.12 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  67.14 ns |  4.195 ns | 0.230 ns |  67.00 ns |  67.41 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.01 ns |  5.582 ns | 0.306 ns |  18.72 ns |  19.33 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.34 ns |  4.713 ns | 0.258 ns |  10.14 ns |  10.63 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **54.61 ns** | **12.737 ns** | **0.698 ns** |  **54.00 ns** |  **55.37 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.23 ns | 34.189 ns | 1.874 ns | 192.02 ns | 195.39 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.65 ns |  9.395 ns | 0.515 ns |  61.18 ns |  62.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.32 ns |  9.740 ns | 0.534 ns |  32.84 ns |  33.90 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.42 ns |  6.009 ns | 0.329 ns |  55.04 ns |  55.65 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 202.33 ns | 14.481 ns | 0.794 ns | 201.51 ns | 203.09 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  58.21 ns |  5.002 ns | 0.274 ns |  57.90 ns |  58.44 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.49 ns |  4.175 ns | 0.229 ns |  34.28 ns |  34.74 ns | 0.0057 |      96 B |
