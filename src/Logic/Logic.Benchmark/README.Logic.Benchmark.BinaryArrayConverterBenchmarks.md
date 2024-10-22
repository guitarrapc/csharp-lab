```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.51 ns** |  **1.290 ns** | **0.071 ns** |  **18.44 ns** |  **18.58 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.95 ns | 18.158 ns | 0.995 ns |  65.33 ns |  67.10 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.38 ns |  1.888 ns | 0.103 ns |  20.27 ns |  20.47 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.82 ns |  1.404 ns | 0.077 ns |  10.77 ns |  10.90 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.47 ns** | **28.654 ns** | **1.571 ns** |  **51.66 ns** |  **54.41 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 214.74 ns | 12.590 ns | 0.690 ns | 214.15 ns | 215.50 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.58 ns | 12.571 ns | 0.689 ns |  62.80 ns |  64.12 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.16 ns |  2.070 ns | 0.113 ns |  36.05 ns |  36.28 ns | 0.0011 |      96 B |
