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
| **ToBinaryArrayInt**             | **1**      |  **18.74 ns** |  **7.964 ns** | **0.437 ns** |  **18.38 ns** |  **19.22 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.61 ns | 11.503 ns | 0.631 ns |  65.24 ns |  66.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.95 ns |  4.898 ns | 0.268 ns |  20.79 ns |  21.26 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.09 ns |  0.314 ns | 0.017 ns |  11.07 ns |  11.11 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.28 ns** | **18.535 ns** | **1.016 ns** |  **57.13 ns** |  **59.04 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.66 ns | 70.180 ns | 3.847 ns | 204.31 ns | 211.10 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.90 ns | 10.275 ns | 0.563 ns |  64.52 ns |  65.55 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.97 ns |  5.114 ns | 0.280 ns |  36.72 ns |  37.27 ns | 0.0011 |      96 B |
