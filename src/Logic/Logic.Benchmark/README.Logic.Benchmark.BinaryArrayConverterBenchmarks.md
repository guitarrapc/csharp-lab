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
| **ToBinaryArrayInt**             | **1**      |  **17.69 ns** |  **4.119 ns** | **0.226 ns** |  **17.52 ns** |  **17.95 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.16 ns |  2.763 ns | 0.151 ns |  65.99 ns |  66.29 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.29 ns |  0.932 ns | 0.051 ns |  20.23 ns |  20.34 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.85 ns |  0.231 ns | 0.013 ns |  10.84 ns |  10.86 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.09 ns** | **27.619 ns** | **1.514 ns** |  **56.77 ns** |  **59.74 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 216.14 ns | 44.560 ns | 2.442 ns | 214.66 ns | 218.95 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.99 ns | 12.114 ns | 0.664 ns |  61.26 ns |  62.55 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  40.01 ns | 94.711 ns | 5.191 ns |  36.88 ns |  46.00 ns | 0.0011 |      96 B |
