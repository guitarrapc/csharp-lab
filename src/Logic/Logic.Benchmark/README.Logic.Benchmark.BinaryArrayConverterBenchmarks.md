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
| **ToBinaryArrayInt**             | **1**      |  **19.25 ns** | **15.403 ns** | **0.844 ns** |  **18.70 ns** |  **20.23 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.26 ns |  1.145 ns | 0.063 ns |  65.20 ns |  65.32 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.08 ns |  2.172 ns | 0.119 ns |  20.99 ns |  21.21 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.15 ns |  0.706 ns | 0.039 ns |  11.11 ns |  11.19 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.74 ns** |  **3.896 ns** | **0.214 ns** |  **57.52 ns** |  **57.95 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.01 ns |  7.228 ns | 0.396 ns | 201.58 ns | 202.36 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.11 ns | 13.760 ns | 0.754 ns |  60.24 ns |  61.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.63 ns |  7.673 ns | 0.421 ns |  36.15 ns |  36.88 ns | 0.0011 |      96 B |
