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
| **ToBinaryArrayInt**             | **1**      |  **18.62 ns** |  **2.986 ns** | **0.164 ns** |  **18.44 ns** |  **18.75 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.68 ns | 55.619 ns | 3.049 ns |  64.73 ns |  70.19 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.99 ns |  4.080 ns | 0.224 ns |  19.85 ns |  20.25 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  15.27 ns |  2.033 ns | 0.111 ns |  15.16 ns |  15.38 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.15 ns** |  **1.844 ns** | **0.101 ns** |  **55.05 ns** |  **55.25 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.33 ns | 10.215 ns | 0.560 ns | 202.69 ns | 203.74 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.65 ns | 14.114 ns | 0.774 ns |  61.78 ns |  63.27 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.74 ns |  6.528 ns | 0.358 ns |  37.44 ns |  38.14 ns | 0.0011 |      96 B |
