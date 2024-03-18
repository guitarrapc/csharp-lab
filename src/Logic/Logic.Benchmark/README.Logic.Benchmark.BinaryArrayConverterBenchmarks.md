```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.43 ns** |  **8.096 ns** | **0.444 ns** |  **17.16 ns** |  **17.94 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.49 ns | 21.614 ns | 1.185 ns |  65.65 ns |  67.84 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.76 ns |  3.107 ns | 0.170 ns |  20.57 ns |  20.90 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.15 ns |  0.998 ns | 0.055 ns |  11.10 ns |  11.21 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.88 ns** |  **5.201 ns** | **0.285 ns** |  **55.64 ns** |  **56.19 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.98 ns |  3.054 ns | 0.167 ns | 202.86 ns | 203.17 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.11 ns | 28.175 ns | 1.544 ns |  60.34 ns |  63.16 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.13 ns |  1.310 ns | 0.072 ns |  36.05 ns |  36.18 ns | 0.0011 |      96 B |
