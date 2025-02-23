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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.33 ns** |  **1.196 ns** | **0.066 ns** |  **17.26 ns** |  **17.39 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.13 ns | 18.575 ns | 1.018 ns |  64.45 ns |  66.30 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.41 ns |  2.779 ns | 0.152 ns |  20.26 ns |  20.56 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.52 ns |  1.821 ns | 0.100 ns |  10.41 ns |  10.60 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.96 ns |  1.693 ns | 0.093 ns |  17.86 ns |  18.04 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.34 ns |  2.852 ns | 0.156 ns |  70.25 ns |  70.52 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.40 ns |  0.303 ns | 0.017 ns |  19.38 ns |  19.41 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.62 ns |  1.406 ns | 0.077 ns |  10.53 ns |  10.69 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.48 ns** | **22.366 ns** | **1.226 ns** |  **55.24 ns** |  **57.69 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 220.72 ns |  8.756 ns | 0.480 ns | 220.18 ns | 221.08 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.38 ns | 16.274 ns | 0.892 ns |  58.38 ns |  60.10 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.47 ns | 10.422 ns | 0.571 ns |  33.93 ns |  35.07 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.90 ns | 18.041 ns | 0.989 ns |  53.77 ns |  55.58 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 215.81 ns | 24.305 ns | 1.332 ns | 214.27 ns | 216.67 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.93 ns | 15.592 ns | 0.855 ns |  59.95 ns |  61.53 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.24 ns |  0.395 ns | 0.022 ns |  35.22 ns |  35.26 ns | 0.0057 |      96 B |
