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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.99 ns** |  **2.853 ns** | **0.156 ns** |  **17.90 ns** |  **18.17 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.48 ns | 14.593 ns | 0.800 ns |  63.01 ns |  64.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.73 ns |  0.835 ns | 0.046 ns |  19.68 ns |  19.77 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.26 ns |  1.360 ns | 0.075 ns |  10.20 ns |  10.35 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.87 ns |  3.393 ns | 0.186 ns |  16.76 ns |  17.09 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  69.89 ns |  6.966 ns | 0.382 ns |  69.46 ns |  70.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.53 ns |  2.849 ns | 0.156 ns |  19.38 ns |  19.69 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.24 ns |  1.125 ns | 0.062 ns |  10.18 ns |  10.30 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.00 ns** |  **0.608 ns** | **0.033 ns** |  **55.96 ns** |  **56.03 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 204.03 ns | 19.532 ns | 1.071 ns | 202.84 ns | 204.92 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.39 ns |  7.285 ns | 0.399 ns |  60.93 ns |  61.64 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  36.07 ns |  6.879 ns | 0.377 ns |  35.64 ns |  36.32 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.08 ns | 13.388 ns | 0.734 ns |  51.54 ns |  52.92 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 207.10 ns |  8.198 ns | 0.449 ns | 206.66 ns | 207.56 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.30 ns |  4.296 ns | 0.235 ns |  60.05 ns |  60.52 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.16 ns |  3.032 ns | 0.166 ns |  35.04 ns |  35.35 ns | 0.0057 |      96 B |
