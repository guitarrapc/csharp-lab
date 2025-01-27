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
| **ToBinaryArrayInt**             | **1**      |  **17.22 ns** |  **4.003 ns** | **0.219 ns** |  **17.08 ns** |  **17.47 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.04 ns | 19.811 ns | 1.086 ns |  68.41 ns |  70.30 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.66 ns | 10.456 ns | 0.573 ns |  19.23 ns |  20.31 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.66 ns |  1.607 ns | 0.088 ns |  10.58 ns |  10.75 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.72 ns** |  **4.303 ns** | **0.236 ns** |  **54.45 ns** |  **54.89 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 237.21 ns | 28.733 ns | 1.575 ns | 236.06 ns | 239.00 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.93 ns |  9.123 ns | 0.500 ns |  59.46 ns |  60.46 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.84 ns |  7.479 ns | 0.410 ns |  36.38 ns |  37.16 ns | 0.0057 |      96 B |
