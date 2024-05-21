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
| **ToBinaryArrayInt**             | **1**      |  **18.83 ns** |  **3.411 ns** | **0.187 ns** |  **18.62 ns** |  **18.98 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.61 ns |  4.058 ns | 0.222 ns |  64.42 ns |  64.86 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.19 ns |  0.797 ns | 0.044 ns |  20.14 ns |  20.22 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  0.196 ns | 0.011 ns |  10.92 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.80 ns** | **34.613 ns** | **1.897 ns** |  **53.62 ns** |  **56.98 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.70 ns |  5.157 ns | 0.283 ns | 197.44 ns | 198.00 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.58 ns | 35.351 ns | 1.938 ns |  62.35 ns |  65.86 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.25 ns |  0.821 ns | 0.045 ns |  36.20 ns |  36.29 ns | 0.0011 |      96 B |
