```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.91 ns** |  **3.842 ns** | **0.211 ns** |  **17.78 ns** |  **18.15 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.29 ns | 21.434 ns | 1.175 ns |  68.60 ns |  70.65 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.86 ns |  4.058 ns | 0.222 ns |  20.64 ns |  21.08 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.02 ns |  1.059 ns | 0.058 ns |  10.98 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.09 ns** |  **9.156 ns** | **0.502 ns** |  **57.51 ns** |  **58.39 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.49 ns |  9.745 ns | 0.534 ns | 198.16 ns | 199.11 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.29 ns | 14.906 ns | 0.817 ns |  62.71 ns |  64.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.26 ns |  3.787 ns | 0.208 ns |  36.07 ns |  36.48 ns | 0.0011 |      96 B |
