```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.32 ns** |  **2.900 ns** | **0.159 ns** |  **18.14 ns** |  **18.44 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.67 ns |  6.987 ns | 0.383 ns |  64.31 ns |  65.07 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.49 ns |  0.821 ns | 0.045 ns |  20.46 ns |  20.54 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.02 ns |  1.824 ns | 0.100 ns |  10.90 ns |  11.08 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.43 ns** | **23.614 ns** | **1.294 ns** |  **55.21 ns** |  **57.78 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 210.51 ns | 22.695 ns | 1.244 ns | 209.18 ns | 211.64 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.80 ns |  7.433 ns | 0.407 ns |  63.40 ns |  64.21 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.71 ns |  4.421 ns | 0.242 ns |  36.47 ns |  36.95 ns | 0.0011 |      96 B |
