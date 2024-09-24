```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.36 ns** | **31.045 ns** | **1.702 ns** |  **18.34 ns** |  **21.33 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.30 ns | 16.076 ns | 0.881 ns |  65.77 ns |  67.31 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.08 ns |  2.569 ns | 0.141 ns |  20.97 ns |  21.24 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.25 ns |  1.272 ns | 0.070 ns |  11.17 ns |  11.30 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.63 ns** | **25.125 ns** | **1.377 ns** |  **57.10 ns** |  **59.78 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.34 ns |  6.838 ns | 0.375 ns | 205.04 ns | 205.76 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.53 ns | 30.137 ns | 1.652 ns |  61.64 ns |  64.68 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.69 ns |  4.682 ns | 0.257 ns |  36.45 ns |  36.96 ns | 0.0011 |      96 B |
