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
| **ToBinaryArrayInt**             | **1**      |  **17.12 ns** |  **5.862 ns** | **0.321 ns** |  **16.93 ns** |  **17.50 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.85 ns |  3.923 ns | 0.215 ns |  65.69 ns |  66.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.39 ns |  3.108 ns | 0.170 ns |  20.29 ns |  20.59 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  2.098 ns | 0.115 ns |  10.75 ns |  10.97 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **51.83 ns** | **26.752 ns** | **1.466 ns** |  **50.62 ns** |  **53.46 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.55 ns |  9.898 ns | 0.543 ns | 200.97 ns | 202.05 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.32 ns | 36.889 ns | 2.022 ns |  61.13 ns |  65.11 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.06 ns |  1.758 ns | 0.096 ns |  37.00 ns |  37.18 ns | 0.0011 |      96 B |
