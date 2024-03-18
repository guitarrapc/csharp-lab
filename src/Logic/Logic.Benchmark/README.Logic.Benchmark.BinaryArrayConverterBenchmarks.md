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
| **ToBinaryArrayInt**             | **1**      |  **19.38 ns** |  **4.954 ns** | **0.272 ns** |  **19.18 ns** |  **19.69 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  74.63 ns |  2.772 ns | 0.152 ns |  74.51 ns |  74.80 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  22.82 ns |  6.025 ns | 0.330 ns |  22.52 ns |  23.17 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  12.56 ns |  1.999 ns | 0.110 ns |  12.47 ns |  12.68 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.96 ns** | **14.558 ns** | **0.798 ns** |  **59.21 ns** |  **60.80 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 218.89 ns | 12.788 ns | 0.701 ns | 218.47 ns | 219.70 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  68.72 ns |  7.504 ns | 0.411 ns |  68.24 ns |  68.97 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  41.74 ns | 19.252 ns | 1.055 ns |  41.05 ns |  42.95 ns | 0.0011 |      96 B |
