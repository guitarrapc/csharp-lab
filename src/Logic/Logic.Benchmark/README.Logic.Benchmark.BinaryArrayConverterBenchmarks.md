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
| **ToBinaryArrayInt**             | **1**      |  **18.66 ns** |  **4.766 ns** | **0.261 ns** |  **18.42 ns** |  **18.94 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.73 ns | 31.779 ns | 1.742 ns |  64.07 ns |  67.54 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.86 ns |  5.072 ns | 0.278 ns |  21.64 ns |  22.17 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  12.48 ns | 22.475 ns | 1.232 ns |  11.06 ns |  13.24 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.35 ns** | **26.710 ns** | **1.464 ns** |  **58.30 ns** |  **61.02 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.97 ns |  7.867 ns | 0.431 ns | 202.60 ns | 203.44 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.75 ns | 13.271 ns | 0.727 ns |  61.92 ns |  63.26 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  34.62 ns |  0.561 ns | 0.031 ns |  34.59 ns |  34.65 ns | 0.0011 |      96 B |
