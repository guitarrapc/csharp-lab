```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.11 ns** |  **9.412 ns** | **0.516 ns** |  **18.59 ns** |  **19.62 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.27 ns |  3.942 ns | 0.216 ns |  66.08 ns |  66.51 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.66 ns |  1.160 ns | 0.064 ns |  20.60 ns |  20.72 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.12 ns |  1.698 ns | 0.093 ns |  11.01 ns |  11.19 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.22 ns** | **10.080 ns** | **0.553 ns** |  **54.76 ns** |  **55.83 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.67 ns |  9.451 ns | 0.518 ns | 207.15 ns | 208.19 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.54 ns | 12.134 ns | 0.665 ns |  64.93 ns |  66.25 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  38.28 ns |  3.252 ns | 0.178 ns |  38.08 ns |  38.43 ns | 0.0011 |      96 B |
