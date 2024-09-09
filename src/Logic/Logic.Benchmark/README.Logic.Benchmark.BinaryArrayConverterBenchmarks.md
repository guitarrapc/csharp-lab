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
| **ToBinaryArrayInt**             | **1**      |  **19.22 ns** |  **0.652 ns** | **0.036 ns** |  **19.17 ns** |  **19.24 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.21 ns |  0.466 ns | 0.026 ns |  66.18 ns |  66.23 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.20 ns |  5.041 ns | 0.276 ns |  19.97 ns |  20.51 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.96 ns |  1.104 ns | 0.061 ns |  10.90 ns |  11.02 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.57 ns** | **26.818 ns** | **1.470 ns** |  **54.91 ns** |  **57.71 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.23 ns | 25.267 ns | 1.385 ns | 200.07 ns | 202.77 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.62 ns | 13.851 ns | 0.759 ns |  64.77 ns |  66.24 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.98 ns |  1.981 ns | 0.109 ns |  35.87 ns |  36.09 ns | 0.0011 |      96 B |
