```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.49 ns** |  **0.529 ns** | **0.029 ns** |  **17.46 ns** |  **17.52 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.20 ns |  4.045 ns | 0.222 ns |  67.00 ns |  67.44 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.37 ns |  0.749 ns | 0.041 ns |  20.32 ns |  20.39 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.17 ns |  4.311 ns | 0.236 ns |  11.01 ns |  11.44 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.66 ns** |  **7.019 ns** | **0.385 ns** |  **52.23 ns** |  **52.97 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 210.59 ns |  6.165 ns | 0.338 ns | 210.23 ns | 210.90 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.18 ns | 10.829 ns | 0.594 ns |  62.52 ns |  63.68 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.40 ns |  3.781 ns | 0.207 ns |  36.21 ns |  36.62 ns | 0.0011 |      96 B |
