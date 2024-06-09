```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.73 ns** | **11.391 ns** | **0.624 ns** |  **18.36 ns** |  **19.45 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.13 ns |  1.580 ns | 0.087 ns |  67.05 ns |  67.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.65 ns |  0.276 ns | 0.015 ns |  20.63 ns |  20.66 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  2.518 ns | 0.138 ns |  10.92 ns |  11.19 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.41 ns** | **48.746 ns** | **2.672 ns** |  **53.32 ns** |  **58.04 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.78 ns | 12.478 ns | 0.684 ns | 203.22 ns | 204.54 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.86 ns |  1.380 ns | 0.076 ns |  64.79 ns |  64.94 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.65 ns |  1.119 ns | 0.061 ns |  37.59 ns |  37.71 ns | 0.0011 |      96 B |
