```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.26 ns** |  **2.700 ns** | **0.148 ns** |  **19.13 ns** |  **19.42 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.41 ns | 24.292 ns | 1.332 ns |  64.98 ns |  67.62 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.47 ns |  1.650 ns | 0.090 ns |  21.41 ns |  21.58 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.18 ns |  0.352 ns | 0.019 ns |  11.16 ns |  11.20 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.42 ns** | **21.037 ns** | **1.153 ns** |  **57.44 ns** |  **59.69 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.54 ns | 21.407 ns | 1.173 ns | 200.62 ns | 202.86 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.75 ns | 19.129 ns | 1.049 ns |  63.84 ns |  65.89 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.62 ns |  1.696 ns | 0.093 ns |  35.53 ns |  35.72 ns | 0.0011 |      96 B |
