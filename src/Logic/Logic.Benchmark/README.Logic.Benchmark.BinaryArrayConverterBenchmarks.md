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
| **ToBinaryArrayInt**             | **.NET 8.0** | **1**      |  **17.51 ns** |  **1.175 ns** | **0.064 ns** |  **17.45 ns** |  **17.58 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 1      |  63.93 ns | 16.724 ns | 0.917 ns |  63.13 ns |  64.93 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 1      |  21.83 ns | 12.612 ns | 0.691 ns |  21.34 ns |  22.62 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 1      |  11.20 ns |  0.354 ns | 0.019 ns |  11.18 ns |  11.22 ns | 0.0019 |      32 B |
| ToBinaryArrayInt             | .NET 9.0 | 1      |  18.11 ns |  1.380 ns | 0.076 ns |  18.04 ns |  18.19 ns | 0.0019 |      32 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 1      |  70.77 ns |  9.092 ns | 0.498 ns |  70.30 ns |  71.29 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 1      |  19.83 ns |  1.537 ns | 0.084 ns |  19.76 ns |  19.92 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 1      |  11.50 ns |  0.905 ns | 0.050 ns |  11.44 ns |  11.54 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **.NET 8.0** | **3**      |  **56.36 ns** | **10.813 ns** | **0.593 ns** |  **55.91 ns** |  **57.03 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | .NET 8.0 | 3      | 200.76 ns | 31.068 ns | 1.703 ns | 199.40 ns | 202.67 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 8.0 | 3      |  59.86 ns | 13.986 ns | 0.767 ns |  58.98 ns |  60.40 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 8.0 | 3      |  34.05 ns |  5.580 ns | 0.306 ns |  33.70 ns |  34.26 ns | 0.0057 |      96 B |
| ToBinaryArrayInt             | .NET 9.0 | 3      |  54.53 ns | 23.837 ns | 1.307 ns |  53.59 ns |  56.02 ns | 0.0057 |      96 B |
| ToBinaryArrayConvertToString | .NET 9.0 | 3      | 208.22 ns | 13.860 ns | 0.760 ns | 207.35 ns | 208.79 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | .NET 9.0 | 3      |  60.91 ns | 14.457 ns | 0.792 ns |  59.99 ns |  61.42 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | .NET 9.0 | 3      |  35.97 ns | 14.512 ns | 0.795 ns |  35.25 ns |  36.82 ns | 0.0057 |      96 B |
