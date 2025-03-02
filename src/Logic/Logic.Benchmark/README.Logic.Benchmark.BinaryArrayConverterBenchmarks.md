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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.58 ns** |  **3.849 ns** | **0.211 ns** |  **17.37 ns** |  **17.80 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  62.32 ns | 13.851 ns | 0.759 ns |  61.84 ns |  63.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  19.47 ns |  1.136 ns | 0.062 ns |  19.41 ns |  19.54 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.42 ns |  1.888 ns | 0.103 ns |  10.32 ns |  10.53 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  16.52 ns |  0.668 ns | 0.037 ns |  16.48 ns |  16.54 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  68.40 ns | 14.929 ns | 0.818 ns |  67.73 ns |  69.31 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  18.48 ns |  0.564 ns | 0.031 ns |  18.45 ns |  18.50 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.91 ns |  1.769 ns | 0.097 ns |  10.82 ns |  11.01 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **55.85 ns** | **20.856 ns** | **1.143 ns** |  **54.65 ns** |  **56.93 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 193.29 ns | 18.122 ns | 0.993 ns | 192.26 ns | 194.24 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  60.17 ns | 10.118 ns | 0.555 ns |  59.78 ns |  60.80 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.22 ns |  7.299 ns | 0.400 ns |  32.87 ns |  33.66 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  52.98 ns |  4.916 ns | 0.269 ns |  52.71 ns |  53.25 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 209.72 ns | 45.213 ns | 2.478 ns | 207.67 ns | 212.48 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  54.73 ns |  4.293 ns | 0.235 ns |  54.48 ns |  54.95 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  34.45 ns |  7.196 ns | 0.394 ns |  34.19 ns |  34.90 ns | 0.0057 |      96 B |
