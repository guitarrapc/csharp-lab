```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.94 ns** | **3.711 ns** | **0.203 ns** |  **18.72 ns** |  **19.13 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.31 ns | 3.012 ns | 0.165 ns |  66.15 ns |  66.48 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.79 ns | 4.927 ns | 0.270 ns |  20.48 ns |  20.96 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns | 1.467 ns | 0.080 ns |  10.96 ns |  11.12 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.26 ns** | **4.286 ns** | **0.235 ns** |  **57.05 ns** |  **57.52 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.22 ns | 7.878 ns | 0.432 ns | 200.89 ns | 201.71 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.08 ns | 8.359 ns | 0.458 ns |  63.79 ns |  64.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  38.34 ns | 2.722 ns | 0.149 ns |  38.24 ns |  38.51 ns | 0.0011 |      96 B |
