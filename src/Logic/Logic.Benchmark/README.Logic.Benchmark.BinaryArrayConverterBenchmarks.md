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
| **ToBinaryArrayInt**             | **1**      |  **17.30 ns** |  **1.858 ns** | **0.102 ns** |  **17.19 ns** |  **17.39 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.35 ns | 13.531 ns | 0.742 ns |  66.82 ns |  68.20 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  18.83 ns |  2.110 ns | 0.116 ns |  18.70 ns |  18.92 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.55 ns |  4.562 ns | 0.250 ns |  10.38 ns |  10.84 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.30 ns** |  **5.455 ns** | **0.299 ns** |  **54.01 ns** |  **54.61 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.57 ns | 36.708 ns | 2.012 ns | 204.14 ns | 207.87 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.76 ns |  8.325 ns | 0.456 ns |  59.39 ns |  60.27 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  33.73 ns |  2.549 ns | 0.140 ns |  33.59 ns |  33.87 ns | 0.0057 |      96 B |
