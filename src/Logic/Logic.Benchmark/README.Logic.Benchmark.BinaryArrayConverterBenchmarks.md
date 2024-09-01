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
| **ToBinaryArrayInt**             | **1**      |  **19.11 ns** |  **2.709 ns** | **0.149 ns** |  **18.99 ns** |  **19.28 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.51 ns |  3.077 ns | 0.169 ns |  64.39 ns |  64.71 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.58 ns |  4.502 ns | 0.247 ns |  20.40 ns |  20.86 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.19 ns |  0.796 ns | 0.044 ns |  11.14 ns |  11.22 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.50 ns** | **25.781 ns** | **1.413 ns** |  **55.41 ns** |  **58.10 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.45 ns |  0.501 ns | 0.027 ns | 203.42 ns | 203.48 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.29 ns | 16.832 ns | 0.923 ns |  61.64 ns |  63.35 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.07 ns | 11.892 ns | 0.652 ns |  36.63 ns |  37.81 ns | 0.0011 |      96 B |
