```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **16.71 ns** |  **3.664 ns** | **0.201 ns** |  **16.49 ns** |  **16.87 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  70.60 ns | 47.289 ns | 2.592 ns |  68.92 ns |  73.59 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  18.81 ns |  9.735 ns | 0.534 ns |  18.49 ns |  19.43 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.28 ns |  1.321 ns | 0.072 ns |  10.20 ns |  10.33 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.32 ns** |  **3.397 ns** | **0.186 ns** |  **53.18 ns** |  **53.53 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.17 ns |  2.643 ns | 0.145 ns | 204.05 ns | 204.33 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.15 ns |  4.133 ns | 0.227 ns |  59.91 ns |  60.35 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  33.67 ns |  1.990 ns | 0.109 ns |  33.55 ns |  33.75 ns | 0.0057 |      96 B |
