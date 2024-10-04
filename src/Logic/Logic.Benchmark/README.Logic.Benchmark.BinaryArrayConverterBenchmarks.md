```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.32 ns** |  **1.703 ns** | **0.093 ns** |  **18.24 ns** |  **18.42 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.06 ns | 63.434 ns | 3.477 ns |  64.72 ns |  71.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.30 ns |  1.618 ns | 0.089 ns |  21.24 ns |  21.41 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |  0.217 ns | 0.012 ns |  11.06 ns |  11.08 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.70 ns** |  **7.213 ns** | **0.395 ns** |  **55.36 ns** |  **56.14 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.48 ns | 12.685 ns | 0.695 ns | 201.99 ns | 203.27 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.51 ns | 12.347 ns | 0.677 ns |  61.74 ns |  62.99 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.28 ns |  4.036 ns | 0.221 ns |  35.09 ns |  35.52 ns | 0.0011 |      96 B |
