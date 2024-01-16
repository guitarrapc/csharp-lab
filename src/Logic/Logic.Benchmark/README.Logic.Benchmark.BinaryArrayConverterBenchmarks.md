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
| **ToBinaryArrayInt**             | **1**      |  **18.48 ns** |  **4.802 ns** | **0.263 ns** |  **18.19 ns** |  **18.70 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.44 ns |  0.944 ns | 0.052 ns |  66.40 ns |  66.50 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.24 ns |  0.435 ns | 0.024 ns |  20.22 ns |  20.26 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  0.932 ns | 0.051 ns |  10.70 ns |  10.79 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **198.21 ns** | **28.351 ns** | **1.554 ns** | **197.00 ns** | **199.96 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 694.59 ns | 22.931 ns | 1.257 ns | 693.54 ns | 695.98 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 225.50 ns | 27.546 ns | 1.510 ns | 224.50 ns | 227.24 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 154.83 ns | 16.630 ns | 0.912 ns | 154.03 ns | 155.83 ns | 0.0038 |     320 B |
