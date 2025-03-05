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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.87 ns** |  **4.914 ns** | **0.269 ns** |  **17.56 ns** |  **18.08 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.66 ns |  6.874 ns | 0.377 ns |  62.33 ns |  63.07 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  18.98 ns |  3.819 ns | 0.209 ns |  18.74 ns |  19.12 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.20 ns |  3.023 ns | 0.166 ns |  10.11 ns |  10.40 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.70 ns |  2.037 ns | 0.112 ns |  16.60 ns |  16.82 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.14 ns |  6.623 ns | 0.363 ns |  69.88 ns |  70.56 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.69 ns |  5.936 ns | 0.325 ns |  19.41 ns |  20.05 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.29 ns |  3.144 ns | 0.172 ns |  10.15 ns |  10.48 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.68 ns** |  **3.266 ns** | **0.179 ns** |  **56.50 ns** |  **56.86 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 191.03 ns | 13.136 ns | 0.720 ns | 190.49 ns | 191.85 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  58.13 ns |  3.572 ns | 0.196 ns |  58.00 ns |  58.35 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  32.77 ns |  3.442 ns | 0.189 ns |  32.64 ns |  32.98 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  55.27 ns |  8.849 ns | 0.485 ns |  54.95 ns |  55.83 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 205.86 ns |  4.974 ns | 0.273 ns | 205.54 ns | 206.04 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  56.87 ns |  9.668 ns | 0.530 ns |  56.34 ns |  57.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.79 ns |  1.599 ns | 0.088 ns |  33.71 ns |  33.88 ns | 0.0057 |      96 B |
