```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.73 ns** |  **1.711 ns** | **0.094 ns** |  **17.67 ns** |  **17.84 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.08 ns | 41.432 ns | 2.271 ns |  67.63 ns |  71.70 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.38 ns |  0.622 ns | 0.034 ns |  20.35 ns |  20.42 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |  0.429 ns | 0.024 ns |  11.03 ns |  11.08 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.74 ns** | **13.072 ns** | **0.717 ns** |  **58.32 ns** |  **59.56 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.63 ns | 31.696 ns | 1.737 ns | 203.52 ns | 206.64 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  67.28 ns | 19.899 ns | 1.091 ns |  66.08 ns |  68.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.67 ns |  3.855 ns | 0.211 ns |  36.44 ns |  36.86 ns | 0.0011 |      96 B |
