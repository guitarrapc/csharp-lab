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
| **ToBinaryArrayInt**             | **1**      |  **18.82 ns** |  **0.961 ns** | **0.053 ns** |  **18.76 ns** |  **18.87 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.26 ns |  3.658 ns | 0.201 ns |  65.03 ns |  65.41 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.00 ns |  3.262 ns | 0.179 ns |  20.82 ns |  21.18 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.21 ns |  3.308 ns | 0.181 ns |  11.10 ns |  11.42 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.14 ns** | **10.860 ns** | **0.595 ns** |  **53.46 ns** |  **54.59 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.04 ns | 15.687 ns | 0.860 ns | 201.11 ns | 202.80 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.76 ns | 16.691 ns | 0.915 ns |  61.71 ns |  63.35 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.02 ns |  3.528 ns | 0.193 ns |  36.86 ns |  37.23 ns | 0.0011 |      96 B |
