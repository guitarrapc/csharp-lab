```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.17 ns** | **10.999 ns** | **0.603 ns** |  **18.68 ns** |  **19.84 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.36 ns |  0.470 ns | 0.026 ns |  64.33 ns |  64.38 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.79 ns |  3.334 ns | 0.183 ns |  19.62 ns |  19.98 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.94 ns |  0.729 ns | 0.040 ns |  10.91 ns |  10.99 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **50.90 ns** | **12.727 ns** | **0.698 ns** |  **50.12 ns** |  **51.46 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.01 ns | 19.768 ns | 1.084 ns | 200.37 ns | 202.26 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.45 ns | 27.416 ns | 1.503 ns |  58.21 ns |  61.12 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.85 ns |  8.048 ns | 0.441 ns |  36.38 ns |  37.25 ns | 0.0011 |      96 B |
