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
| **ToBinaryArrayInt**             | **1**      |  **18.45 ns** |  **8.458 ns** | **0.464 ns** |  **17.92 ns** |  **18.77 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.46 ns | 23.791 ns | 1.304 ns |  65.46 ns |  67.93 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.05 ns |  2.300 ns | 0.126 ns |  20.91 ns |  21.14 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.96 ns |  1.089 ns | 0.060 ns |  10.90 ns |  11.02 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.77 ns** |  **6.164 ns** | **0.338 ns** |  **59.54 ns** |  **60.16 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.17 ns |  4.101 ns | 0.225 ns | 200.91 ns | 201.32 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.53 ns | 16.885 ns | 0.926 ns |  60.55 ns |  62.38 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.37 ns | 10.023 ns | 0.549 ns |  35.81 ns |  36.91 ns | 0.0011 |      96 B |
