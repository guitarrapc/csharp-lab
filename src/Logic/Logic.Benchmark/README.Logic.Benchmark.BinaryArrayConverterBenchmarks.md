```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **21.09 ns** |   **3.563 ns** | **0.195 ns** |  **20.87 ns** |  **21.23 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.15 ns |  23.891 ns | 1.310 ns |  65.09 ns |  67.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.23 ns |   3.145 ns | 0.172 ns |  20.10 ns |  20.42 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.86 ns |   0.353 ns | 0.019 ns |  10.84 ns |  10.87 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **182.83 ns** |  **53.041 ns** | **2.907 ns** | **179.67 ns** | **185.39 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.42 ns | 119.786 ns | 6.566 ns | 690.87 ns | 702.95 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 220.60 ns |  27.317 ns | 1.497 ns | 219.38 ns | 222.27 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 157.13 ns |  44.429 ns | 2.435 ns | 155.20 ns | 159.87 ns | 0.0038 |     320 B |
