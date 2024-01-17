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
| **ToBinaryArrayInt**             | **1**      |  **17.88 ns** |  **8.434 ns** | **0.462 ns** |  **17.40 ns** |  **18.32 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.61 ns |  5.805 ns | 0.318 ns |  66.24 ns |  66.82 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.61 ns |  8.203 ns | 0.450 ns |  20.27 ns |  21.12 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  2.963 ns | 0.162 ns |  10.78 ns |  11.10 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **189.47 ns** | **94.145 ns** | **5.160 ns** | **183.84 ns** | **193.97 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 678.60 ns | 45.430 ns | 2.490 ns | 677.16 ns | 681.48 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 226.54 ns | 90.002 ns | 4.933 ns | 221.09 ns | 230.70 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.55 ns | 31.617 ns | 1.733 ns | 150.50 ns | 153.55 ns | 0.0038 |     320 B |
