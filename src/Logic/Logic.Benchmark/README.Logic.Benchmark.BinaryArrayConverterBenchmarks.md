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
| **ToBinaryArrayInt**             | **1**      |  **18.81 ns** |   **1.753 ns** | **0.096 ns** |  **18.72 ns** |  **18.91 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.98 ns |   7.846 ns | 0.430 ns |  65.69 ns |  66.48 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.35 ns |   1.747 ns | 0.096 ns |  20.28 ns |  20.46 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |   0.632 ns | 0.035 ns |  10.90 ns |  10.96 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **190.30 ns** |  **23.811 ns** | **1.305 ns** | **188.89 ns** | **191.47 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 694.63 ns |  34.240 ns | 1.877 ns | 692.98 ns | 696.67 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 232.40 ns |  31.712 ns | 1.738 ns | 230.89 ns | 234.30 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 159.69 ns | 163.136 ns | 8.942 ns | 149.46 ns | 166.01 ns | 0.0038 |     320 B |
