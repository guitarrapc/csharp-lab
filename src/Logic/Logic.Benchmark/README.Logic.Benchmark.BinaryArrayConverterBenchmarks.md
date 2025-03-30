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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.15 ns** |  **1.843 ns** | **0.101 ns** |  **17.08 ns** |  **17.26 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.84 ns | 44.300 ns | 2.428 ns |  64.10 ns |  68.61 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.23 ns |  0.637 ns | 0.035 ns |  19.19 ns |  19.26 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.66 ns |  4.165 ns | 0.228 ns |  10.50 ns |  10.93 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.66 ns |  0.711 ns | 0.039 ns |  16.64 ns |  16.71 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.76 ns |  8.541 ns | 0.468 ns |  68.22 ns |  69.09 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.99 ns |  1.123 ns | 0.062 ns |  18.94 ns |  19.06 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.47 ns |  3.713 ns | 0.204 ns |  10.35 ns |  10.70 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.33 ns** | **16.173 ns** | **0.886 ns** |  **54.30 ns** |  **55.85 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 196.47 ns | 41.275 ns | 2.262 ns | 193.86 ns | 197.83 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  63.12 ns | 18.756 ns | 1.028 ns |  62.28 ns |  64.27 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  35.23 ns |  3.515 ns | 0.193 ns |  35.02 ns |  35.41 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  53.87 ns | 12.337 ns | 0.676 ns |  53.14 ns |  54.47 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 210.49 ns | 33.465 ns | 1.834 ns | 208.97 ns | 212.53 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  56.14 ns |  5.526 ns | 0.303 ns |  55.80 ns |  56.39 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.63 ns |  2.757 ns | 0.151 ns |  34.48 ns |  34.78 ns | 0.0057 |      96 B |
