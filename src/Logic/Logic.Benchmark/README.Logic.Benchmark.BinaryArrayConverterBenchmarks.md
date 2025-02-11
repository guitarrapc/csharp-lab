```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **18.21 ns** |  **2.992 ns** | **0.164 ns** |  **18.06 ns** |  **18.39 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  65.28 ns |  7.529 ns | 0.413 ns |  64.81 ns |  65.58 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  20.89 ns |  3.758 ns | 0.206 ns |  20.69 ns |  21.10 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  10.59 ns |  1.444 ns | 0.079 ns |  10.51 ns |  10.67 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  17.27 ns |  0.759 ns | 0.042 ns |  17.22 ns |  17.30 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  69.54 ns |  5.501 ns | 0.302 ns |  69.25 ns |  69.85 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.32 ns |  5.622 ns | 0.308 ns |  18.97 ns |  19.51 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  10.43 ns |  1.184 ns | 0.065 ns |  10.36 ns |  10.48 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.02 ns** |  **8.853 ns** | **0.485 ns** |  **55.46 ns** |  **56.35 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 197.27 ns | 25.691 ns | 1.408 ns | 196.10 ns | 198.83 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  63.63 ns |  3.471 ns | 0.190 ns |  63.43 ns |  63.81 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  33.56 ns | 14.401 ns | 0.789 ns |  32.85 ns |  34.41 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.75 ns |  7.379 ns | 0.404 ns |  54.39 ns |  55.19 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 213.16 ns | 53.902 ns | 2.955 ns | 209.91 ns | 215.68 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.20 ns |  2.514 ns | 0.138 ns |  60.06 ns |  60.33 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  33.46 ns |  0.276 ns | 0.015 ns |  33.45 ns |  33.48 ns | 0.0057 |      96 B |
