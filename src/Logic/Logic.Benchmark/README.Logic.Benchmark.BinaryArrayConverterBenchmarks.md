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
| **ToBinaryArrayInt**             | **1**      |  **18.62 ns** |  **7.733 ns** | **0.424 ns** |  **18.27 ns** |  **19.09 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.52 ns | 61.816 ns | 3.388 ns |  65.14 ns |  71.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.39 ns |  3.249 ns | 0.178 ns |  20.20 ns |  20.55 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.92 ns |  1.636 ns | 0.090 ns |  10.87 ns |  11.03 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.30 ns** |  **7.517 ns** | **0.412 ns** |  **53.94 ns** |  **54.75 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 208.68 ns |  3.503 ns | 0.192 ns | 208.46 ns | 208.80 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.65 ns | 34.204 ns | 1.875 ns |  62.62 ns |  66.31 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.83 ns |  5.402 ns | 0.296 ns |  37.52 ns |  38.11 ns | 0.0011 |      96 B |
