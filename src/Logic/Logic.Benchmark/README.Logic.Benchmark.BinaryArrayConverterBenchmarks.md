```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.98 ns** |  **5.130 ns** | **0.281 ns** |  **17.80 ns** |  **18.31 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.06 ns |  8.531 ns | 0.468 ns |  64.53 ns |  65.40 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.32 ns |  0.944 ns | 0.052 ns |  20.28 ns |  20.37 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.81 ns |  1.110 ns | 0.061 ns |  10.75 ns |  10.87 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.05 ns** | **17.711 ns** | **0.971 ns** |  **58.38 ns** |  **60.16 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.77 ns | 42.058 ns | 2.305 ns | 199.26 ns | 203.42 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.56 ns | 23.539 ns | 1.290 ns |  65.10 ns |  67.53 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.67 ns |  2.588 ns | 0.142 ns |  35.58 ns |  35.84 ns | 0.0011 |      96 B |
