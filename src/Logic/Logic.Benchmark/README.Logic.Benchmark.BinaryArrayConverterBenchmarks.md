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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.23 ns** |  **1.443 ns** | **0.079 ns** |  **17.14 ns** |  **17.30 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.84 ns |  7.285 ns | 0.399 ns |  62.41 ns |  63.21 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.39 ns |  0.809 ns | 0.044 ns |  19.36 ns |  19.44 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.15 ns |  1.552 ns | 0.085 ns |  10.06 ns |  10.22 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.35 ns |  2.890 ns | 0.158 ns |  17.21 ns |  17.52 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  67.63 ns |  7.102 ns | 0.389 ns |  67.35 ns |  68.07 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.61 ns |  7.927 ns | 0.434 ns |  18.23 ns |  19.08 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.60 ns |  0.492 ns | 0.027 ns |  10.58 ns |  10.63 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **60.97 ns** |  **7.958 ns** | **0.436 ns** |  **60.52 ns** |  **61.39 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.15 ns | 20.528 ns | 1.125 ns | 192.02 ns | 194.27 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.97 ns |  5.340 ns | 0.293 ns |  60.64 ns |  61.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  36.89 ns |  2.929 ns | 0.161 ns |  36.71 ns |  37.01 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.55 ns |  4.585 ns | 0.251 ns |  52.33 ns |  52.82 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 210.50 ns | 36.312 ns | 1.990 ns | 208.22 ns | 211.89 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  59.50 ns |  3.989 ns | 0.219 ns |  59.27 ns |  59.71 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.77 ns |  4.092 ns | 0.224 ns |  33.56 ns |  34.01 ns | 0.0057 |      96 B |
