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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.13 ns** |  **5.086 ns** | **0.279 ns** |  **16.91 ns** |  **17.44 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  61.88 ns | 10.288 ns | 0.564 ns |  61.55 ns |  62.53 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.85 ns |  4.228 ns | 0.232 ns |  19.67 ns |  20.11 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.30 ns |  2.857 ns | 0.157 ns |  10.16 ns |  10.47 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.62 ns |  1.574 ns | 0.086 ns |  17.56 ns |  17.72 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.30 ns |  2.039 ns | 0.112 ns |  70.20 ns |  70.42 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.92 ns |  3.256 ns | 0.178 ns |  18.72 ns |  19.07 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.26 ns |  1.065 ns | 0.058 ns |  10.22 ns |  10.33 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.63 ns** | **19.302 ns** | **1.058 ns** |  **54.42 ns** |  **56.39 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.63 ns |  9.836 ns | 0.539 ns | 193.04 ns | 194.11 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  58.73 ns | 24.646 ns | 1.351 ns |  57.61 ns |  60.23 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.93 ns |  1.563 ns | 0.086 ns |  33.83 ns |  33.99 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.73 ns |  8.125 ns | 0.445 ns |  53.25 ns |  54.12 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 205.70 ns | 12.794 ns | 0.701 ns | 204.95 ns | 206.34 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.99 ns |  6.829 ns | 0.374 ns |  60.55 ns |  61.22 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.54 ns |  4.557 ns | 0.250 ns |  34.26 ns |  34.75 ns | 0.0057 |      96 B |
