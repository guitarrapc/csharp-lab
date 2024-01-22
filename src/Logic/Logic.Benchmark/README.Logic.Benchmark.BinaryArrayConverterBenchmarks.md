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
| **ToBinaryArrayInt**             | **1**      |  **17.98 ns** |  **1.339 ns** | **0.073 ns** |  **17.93 ns** |  **18.06 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.13 ns |  0.335 ns | 0.018 ns |  67.12 ns |  67.15 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.32 ns |  2.974 ns | 0.163 ns |  20.18 ns |  20.50 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  1.162 ns | 0.064 ns |  10.86 ns |  10.98 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **196.62 ns** |  **4.764 ns** | **0.261 ns** | **196.42 ns** | **196.91 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 709.43 ns | 12.464 ns | 0.683 ns | 708.65 ns | 709.96 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 224.43 ns | 87.706 ns | 4.807 ns | 219.58 ns | 229.20 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 153.75 ns | 36.942 ns | 2.025 ns | 151.93 ns | 155.93 ns | 0.0038 |     320 B |
