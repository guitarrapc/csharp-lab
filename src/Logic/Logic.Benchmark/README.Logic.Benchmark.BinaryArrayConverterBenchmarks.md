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
| **ToBinaryArrayInt**             | **1**      |  **19.04 ns** |  **1.560 ns** | **0.086 ns** |  **18.98 ns** |  **19.14 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.79 ns |  3.370 ns | 0.185 ns |  64.67 ns |  65.00 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.65 ns |  4.277 ns | 0.234 ns |  20.48 ns |  20.92 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.00 ns |  2.985 ns | 0.164 ns |  10.85 ns |  11.17 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **204.46 ns** | **22.965 ns** | **1.259 ns** | **203.33 ns** | **205.81 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.44 ns | 15.077 ns | 0.826 ns | 694.91 ns | 696.39 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 224.93 ns | 96.055 ns | 5.265 ns | 220.99 ns | 230.91 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.73 ns | 27.605 ns | 1.513 ns | 149.98 ns | 152.67 ns | 0.0038 |     320 B |
