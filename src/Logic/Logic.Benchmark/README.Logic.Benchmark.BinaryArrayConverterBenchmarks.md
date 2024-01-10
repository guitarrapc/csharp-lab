```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.86 ns** |   **3.006 ns** | **0.165 ns** |  **17.74 ns** |  **18.05 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.21 ns |   8.231 ns | 0.451 ns |  66.88 ns |  67.72 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.50 ns |   3.342 ns | 0.183 ns |  20.34 ns |  20.70 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |   3.247 ns | 0.178 ns |  10.93 ns |  11.27 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **205.04 ns** | **107.981 ns** | **5.919 ns** | **198.27 ns** | **209.24 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 711.12 ns |  39.679 ns | 2.175 ns | 709.26 ns | 713.51 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 226.86 ns |  96.771 ns | 5.304 ns | 221.94 ns | 232.48 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 155.98 ns |  16.813 ns | 0.922 ns | 155.32 ns | 157.04 ns | 0.0038 |     320 B |
