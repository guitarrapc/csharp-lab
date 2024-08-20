```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.54 ns** |  **3.486 ns** | **0.191 ns** |  **17.41 ns** |  **17.76 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.72 ns | 74.532 ns | 4.085 ns |  64.29 ns |  71.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.60 ns |  2.135 ns | 0.117 ns |  20.47 ns |  20.70 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.00 ns |  1.638 ns | 0.090 ns |  10.91 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.06 ns** | **19.708 ns** | **1.080 ns** |  **50.88 ns** |  **53.00 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.83 ns | 79.778 ns | 4.373 ns | 198.82 ns | 206.88 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.33 ns | 24.123 ns | 1.322 ns |  62.96 ns |  65.60 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.32 ns |  9.944 ns | 0.545 ns |  35.81 ns |  36.89 ns | 0.0011 |      96 B |
