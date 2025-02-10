```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.10 ns** | **2.543 ns** | **0.139 ns** |  **16.94 ns** |  **17.21 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.82 ns | 2.971 ns | 0.163 ns |  69.70 ns |  70.01 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.32 ns | 2.192 ns | 0.120 ns |  19.18 ns |  19.40 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.25 ns | 0.288 ns | 0.016 ns |  10.23 ns |  10.26 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.15 ns** | **8.986 ns** | **0.493 ns** |  **51.58 ns** |  **52.45 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.86 ns | 8.768 ns | 0.481 ns | 202.34 ns | 203.28 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.25 ns | 3.740 ns | 0.205 ns |  60.09 ns |  60.48 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.59 ns | 6.430 ns | 0.352 ns |  34.36 ns |  35.00 ns | 0.0057 |      96 B |
