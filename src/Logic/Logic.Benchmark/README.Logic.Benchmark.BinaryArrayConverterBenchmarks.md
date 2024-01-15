```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.67 ns** |  **6.069 ns** | **0.333 ns** |  **18.34 ns** |  **19.01 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.96 ns |  2.098 ns | 0.115 ns |  65.86 ns |  66.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.77 ns |  8.674 ns | 0.475 ns |  20.48 ns |  21.32 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.30 ns |  9.273 ns | 0.508 ns |  10.99 ns |  11.89 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **197.61 ns** | **34.178 ns** | **1.873 ns** | **195.57 ns** | **199.27 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 726.50 ns | 35.835 ns | 1.964 ns | 724.24 ns | 727.70 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 239.91 ns | 63.282 ns | 3.469 ns | 236.28 ns | 243.19 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 156.13 ns | 13.703 ns | 0.751 ns | 155.48 ns | 156.95 ns | 0.0038 |     320 B |
