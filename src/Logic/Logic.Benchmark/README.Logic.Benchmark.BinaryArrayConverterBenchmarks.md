```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.18 ns** |  **2.740 ns** | **0.150 ns** |  **19.01 ns** |  **19.29 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.57 ns |  3.587 ns | 0.197 ns |  67.38 ns |  67.78 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.63 ns |  3.716 ns | 0.204 ns |  20.44 ns |  20.84 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.32 ns |  0.979 ns | 0.054 ns |  11.27 ns |  11.38 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.53 ns** | **18.716 ns** | **1.026 ns** |  **54.80 ns** |  **56.71 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.03 ns |  6.118 ns | 0.335 ns | 199.73 ns | 200.39 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.62 ns | 18.026 ns | 0.988 ns |  65.72 ns |  67.68 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.84 ns |  3.451 ns | 0.189 ns |  36.62 ns |  36.96 ns | 0.0011 |      96 B |
