```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.81 ns** |  **3.142 ns** | **0.172 ns** |  **18.62 ns** |  **18.92 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.90 ns |  5.967 ns | 0.327 ns |  64.64 ns |  65.27 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.93 ns |  3.125 ns | 0.171 ns |  20.74 ns |  21.08 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  1.806 ns | 0.099 ns |  10.85 ns |  11.04 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.80 ns** | **14.101 ns** | **0.773 ns** |  **57.04 ns** |  **58.58 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 211.66 ns |  9.091 ns | 0.498 ns | 211.25 ns | 212.22 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.76 ns |  7.751 ns | 0.425 ns |  61.27 ns |  62.08 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.03 ns |  4.810 ns | 0.264 ns |  34.76 ns |  35.29 ns | 0.0011 |      96 B |
