```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.89 ns** |   **7.890 ns** |  **0.432 ns** |  **17.60 ns** |  **18.39 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.62 ns |  25.923 ns |  1.421 ns |  67.00 ns |  69.64 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.43 ns |   2.695 ns |  0.148 ns |  20.26 ns |  20.55 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.10 ns |   2.273 ns |  0.125 ns |  11.01 ns |  11.24 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **198.67 ns** | **203.149 ns** | **11.135 ns** | **185.87 ns** | **206.10 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 702.82 ns | 152.768 ns |  8.374 ns | 697.50 ns | 712.47 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 236.43 ns |  38.375 ns |  2.103 ns | 234.23 ns | 238.42 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 154.78 ns |  39.965 ns |  2.191 ns | 153.39 ns | 157.30 ns | 0.0038 |     320 B |
