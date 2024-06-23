```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.13 ns** |  **0.778 ns** | **0.043 ns** |  **19.09 ns** |  **19.17 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.92 ns |  1.103 ns | 0.060 ns |  64.88 ns |  64.99 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.44 ns |  5.084 ns | 0.279 ns |  20.27 ns |  20.76 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  1.858 ns | 0.102 ns |  10.97 ns |  11.16 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.14 ns** | **20.934 ns** | **1.147 ns** |  **56.84 ns** |  **59.00 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 199.26 ns | 13.359 ns | 0.732 ns | 198.60 ns | 200.05 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.43 ns | 34.743 ns | 1.904 ns |  62.00 ns |  65.59 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.73 ns | 11.590 ns | 0.635 ns |  36.05 ns |  37.30 ns | 0.0011 |      96 B |
