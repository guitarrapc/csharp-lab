```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.63 ns** |  **4.428 ns** | **0.243 ns** |  **19.35 ns** |  **19.80 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.08 ns |  0.319 ns | 0.017 ns |  67.07 ns |  67.10 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.66 ns |  3.282 ns | 0.180 ns |  20.50 ns |  20.85 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |  0.843 ns | 0.046 ns |  11.02 ns |  11.11 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **57.95 ns** |  **8.130 ns** | **0.446 ns** |  **57.63 ns** |  **58.46 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 208.79 ns | 31.137 ns | 1.707 ns | 207.52 ns | 210.73 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.24 ns |  3.041 ns | 0.167 ns |  63.10 ns |  63.42 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  39.82 ns |  3.969 ns | 0.218 ns |  39.57 ns |  39.98 ns | 0.0011 |      96 B |
