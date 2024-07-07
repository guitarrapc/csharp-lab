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
| **ToBinaryArrayInt**             | **1**      |  **18.56 ns** |  **5.921 ns** | **0.325 ns** |  **18.19 ns** |  **18.79 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.93 ns | 29.097 ns | 1.595 ns |  67.91 ns |  70.77 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.79 ns |  9.620 ns | 0.527 ns |  20.28 ns |  21.33 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.84 ns |  0.932 ns | 0.051 ns |  10.78 ns |  10.88 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.18 ns** | **10.797 ns** | **0.592 ns** |  **56.73 ns** |  **57.85 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.54 ns |  5.695 ns | 0.312 ns | 198.31 ns | 198.90 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.69 ns |  3.008 ns | 0.165 ns |  63.51 ns |  63.83 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.30 ns |  1.509 ns | 0.083 ns |  36.25 ns |  36.40 ns | 0.0011 |      96 B |
