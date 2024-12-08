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
| **ToBinaryArrayInt**             | **1**      |  **18.62 ns** |  **2.465 ns** | **0.135 ns** |  **18.54 ns** |  **18.78 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.38 ns | 49.860 ns | 2.733 ns |  65.57 ns |  70.52 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.45 ns |  3.699 ns | 0.203 ns |  20.30 ns |  20.68 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |  0.571 ns | 0.031 ns |  10.83 ns |  10.89 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.80 ns** |  **7.133 ns** | **0.391 ns** |  **58.49 ns** |  **59.24 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.75 ns | 68.379 ns | 3.748 ns | 204.39 ns | 211.07 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.86 ns | 31.162 ns | 1.708 ns |  61.82 ns |  64.83 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.32 ns |  5.039 ns | 0.276 ns |  36.01 ns |  36.53 ns | 0.0011 |      96 B |
