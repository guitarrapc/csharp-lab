```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.91 ns** |  **1.865 ns** | **0.102 ns** |  **18.85 ns** |  **19.03 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.47 ns |  3.064 ns | 0.168 ns |  67.28 ns |  67.59 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.10 ns |  9.040 ns | 0.496 ns |  20.77 ns |  21.67 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.15 ns |  0.223 ns | 0.012 ns |  11.14 ns |  11.17 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.42 ns** | **10.988 ns** | **0.602 ns** |  **56.76 ns** |  **57.94 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.31 ns |  4.402 ns | 0.241 ns | 202.15 ns | 202.58 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.97 ns |  6.642 ns | 0.364 ns |  63.56 ns |  64.25 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.47 ns | 17.991 ns | 0.986 ns |  36.90 ns |  38.61 ns | 0.0011 |      96 B |
