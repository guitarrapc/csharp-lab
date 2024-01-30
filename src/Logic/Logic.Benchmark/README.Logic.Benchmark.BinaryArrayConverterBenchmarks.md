```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.75 ns** |  **1.561 ns** | **0.086 ns** |  **17.67 ns** |  **17.84 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.16 ns |  3.433 ns | 0.188 ns |  67.01 ns |  67.37 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.85 ns |  3.633 ns | 0.199 ns |  20.63 ns |  21.01 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  2.089 ns | 0.114 ns |  10.86 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **193.39 ns** | **65.639 ns** | **3.598 ns** | **189.34 ns** | **196.24 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.14 ns | 60.558 ns | 3.319 ns | 691.40 ns | 697.74 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 235.30 ns | 46.728 ns | 2.561 ns | 232.35 ns | 236.96 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.30 ns | 43.184 ns | 2.367 ns | 149.08 ns | 153.79 ns | 0.0038 |     320 B |
