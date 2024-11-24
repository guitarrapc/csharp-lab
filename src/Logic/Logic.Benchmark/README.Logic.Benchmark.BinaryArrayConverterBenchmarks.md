```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.08 ns** |  **2.759 ns** | **0.151 ns** |  **17.95 ns** |  **18.25 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.59 ns | 14.975 ns | 0.821 ns |  66.03 ns |  67.53 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.01 ns |  8.681 ns | 0.476 ns |  19.46 ns |  20.29 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.94 ns |  1.495 ns | 0.082 ns |  10.85 ns |  11.01 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.13 ns** | **11.817 ns** | **0.648 ns** |  **53.49 ns** |  **54.78 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.25 ns | 12.430 ns | 0.681 ns | 203.77 ns | 205.03 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.15 ns | 13.726 ns | 0.752 ns |  59.28 ns |  60.64 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.07 ns |  7.087 ns | 0.388 ns |  35.81 ns |  36.52 ns | 0.0011 |      96 B |
