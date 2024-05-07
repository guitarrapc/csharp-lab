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
| **ToBinaryArrayInt**             | **1**      |  **18.43 ns** |  **8.853 ns** | **0.485 ns** |  **17.94 ns** |  **18.91 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.82 ns |  1.386 ns | 0.076 ns |  66.75 ns |  66.90 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.68 ns |  1.432 ns | 0.078 ns |  20.62 ns |  20.77 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.24 ns |  1.948 ns | 0.107 ns |  11.18 ns |  11.37 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.92 ns** | **23.375 ns** | **1.281 ns** |  **52.45 ns** |  **54.75 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.57 ns | 32.226 ns | 1.766 ns | 202.51 ns | 205.61 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  67.24 ns |  8.570 ns | 0.470 ns |  66.75 ns |  67.68 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.01 ns |  4.260 ns | 0.234 ns |  36.86 ns |  37.28 ns | 0.0011 |      96 B |
