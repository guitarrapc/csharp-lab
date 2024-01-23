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
| **ToBinaryArrayInt**             | **1**      |  **19.19 ns** |  **1.364 ns** | **0.075 ns** |  **19.14 ns** |  **19.28 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.86 ns |  0.768 ns | 0.042 ns |  65.81 ns |  65.90 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.54 ns |  5.729 ns | 0.314 ns |  20.31 ns |  20.90 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.97 ns |  0.558 ns | 0.031 ns |  10.94 ns |  11.00 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **202.46 ns** | **47.749 ns** | **2.617 ns** | **200.59 ns** | **205.45 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 717.68 ns | 96.531 ns | 5.291 ns | 713.66 ns | 723.68 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 232.56 ns | 45.698 ns | 2.505 ns | 229.78 ns | 234.64 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.07 ns | 19.058 ns | 1.045 ns | 150.24 ns | 152.25 ns | 0.0038 |     320 B |
