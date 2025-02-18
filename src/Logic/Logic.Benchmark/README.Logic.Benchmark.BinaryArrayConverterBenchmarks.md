```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **16.97 ns** |  **2.235 ns** | **0.123 ns** |  **16.83 ns** |  **17.07 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.43 ns |  6.541 ns | 0.359 ns |  62.02 ns |  62.65 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.69 ns |  4.618 ns | 0.253 ns |  19.42 ns |  19.92 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.18 ns |  1.204 ns | 0.066 ns |  10.11 ns |  10.23 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.40 ns |  3.220 ns | 0.176 ns |  17.27 ns |  17.60 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.44 ns |  6.312 ns | 0.346 ns |  70.15 ns |  70.82 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.81 ns |  8.366 ns | 0.459 ns |  19.47 ns |  20.34 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.42 ns |  2.017 ns | 0.111 ns |  10.29 ns |  10.49 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.54 ns** | **11.853 ns** | **0.650 ns** |  **54.90 ns** |  **56.19 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 191.94 ns |  8.715 ns | 0.478 ns | 191.49 ns | 192.44 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  61.24 ns | 13.919 ns | 0.763 ns |  60.37 ns |  61.77 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.63 ns | 11.241 ns | 0.616 ns |  33.98 ns |  35.20 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.22 ns |  4.553 ns | 0.250 ns |  53.95 ns |  54.44 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 210.09 ns | 31.854 ns | 1.746 ns | 209.05 ns | 212.10 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.62 ns |  6.078 ns | 0.333 ns |  60.41 ns |  61.01 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.66 ns | 10.693 ns | 0.586 ns |  34.20 ns |  35.32 ns | 0.0057 |      96 B |
