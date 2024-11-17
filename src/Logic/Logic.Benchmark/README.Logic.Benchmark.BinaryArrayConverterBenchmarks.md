```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.82 ns** |  **2.046 ns** | **0.112 ns** |  **17.69 ns** |  **17.91 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.89 ns |  1.087 ns | 0.060 ns |  64.82 ns |  64.92 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.73 ns |  4.478 ns | 0.245 ns |  20.58 ns |  21.01 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.70 ns |  2.461 ns | 0.135 ns |  10.61 ns |  10.86 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.83 ns** |  **3.719 ns** | **0.204 ns** |  **54.71 ns** |  **55.07 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.85 ns | 13.269 ns | 0.727 ns | 197.31 ns | 198.68 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.32 ns | 14.031 ns | 0.769 ns |  59.67 ns |  61.17 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.58 ns |  7.401 ns | 0.406 ns |  36.28 ns |  37.04 ns | 0.0011 |      96 B |
