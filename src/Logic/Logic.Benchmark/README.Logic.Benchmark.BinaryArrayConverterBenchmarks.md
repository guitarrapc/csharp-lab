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
| **ToBinaryArrayInt**             | **1**      |  **17.15 ns** |  **4.508 ns** | **0.247 ns** |  **16.98 ns** |  **17.43 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.36 ns |  4.138 ns | 0.227 ns |  66.13 ns |  66.58 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.61 ns |  6.760 ns | 0.371 ns |  20.36 ns |  21.03 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.09 ns |  3.955 ns | 0.217 ns |  10.96 ns |  11.34 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.31 ns** | **14.800 ns** | **0.811 ns** |  **52.39 ns** |  **53.90 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.28 ns |  8.585 ns | 0.471 ns | 206.88 ns | 207.80 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.85 ns | 14.597 ns | 0.800 ns |  61.13 ns |  62.71 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.51 ns |  2.229 ns | 0.122 ns |  35.41 ns |  35.64 ns | 0.0011 |      96 B |
