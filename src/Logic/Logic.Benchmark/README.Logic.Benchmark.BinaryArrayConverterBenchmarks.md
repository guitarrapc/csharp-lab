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
| **ToBinaryArrayInt**             | **1**      |  **17.35 ns** |  **0.254 ns** | **0.014 ns** |  **17.34 ns** |  **17.37 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.97 ns | 20.426 ns | 1.120 ns |  66.10 ns |  68.24 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.47 ns |  8.716 ns | 0.478 ns |  20.17 ns |  21.02 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.98 ns |  1.534 ns | 0.084 ns |  10.90 ns |  11.07 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **205.26 ns** | **49.051 ns** | **2.689 ns** | **202.17 ns** | **207.10 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 694.86 ns |  9.109 ns | 0.499 ns | 694.56 ns | 695.44 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 233.51 ns | 74.481 ns | 4.083 ns | 229.71 ns | 237.82 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 153.31 ns | 12.623 ns | 0.692 ns | 152.82 ns | 154.10 ns | 0.0038 |     320 B |
