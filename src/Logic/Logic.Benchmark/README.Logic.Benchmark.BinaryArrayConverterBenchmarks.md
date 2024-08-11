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
| **ToBinaryArrayInt**             | **1**      |  **18.14 ns** |  **1.424 ns** | **0.078 ns** |  **18.08 ns** |  **18.23 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.23 ns |  2.138 ns | 0.117 ns |  66.10 ns |  66.34 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.88 ns |  6.409 ns | 0.351 ns |  20.56 ns |  21.26 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.98 ns |  0.254 ns | 0.014 ns |  10.97 ns |  11.00 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.47 ns** |  **3.207 ns** | **0.176 ns** |  **58.27 ns** |  **58.59 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 197.80 ns | 12.493 ns | 0.685 ns | 197.29 ns | 198.58 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.97 ns |  7.665 ns | 0.420 ns |  65.49 ns |  66.29 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.71 ns |  2.001 ns | 0.110 ns |  36.59 ns |  36.80 ns | 0.0011 |      96 B |
