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
| **ToBinaryArrayInt**             | **1**      |  **18.51 ns** |  **3.688 ns** | **0.202 ns** |  **18.31 ns** |  **18.71 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.49 ns |  1.798 ns | 0.099 ns |  66.40 ns |  66.59 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.42 ns |  0.399 ns | 0.022 ns |  20.39 ns |  20.44 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.96 ns |  1.185 ns | 0.065 ns |  10.88 ns |  11.00 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **197.59 ns** | **25.437 ns** | **1.394 ns** | **196.28 ns** | **199.06 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 697.74 ns | 27.436 ns | 1.504 ns | 696.05 ns | 698.91 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 238.90 ns | 47.895 ns | 2.625 ns | 237.09 ns | 241.91 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 152.68 ns | 22.490 ns | 1.233 ns | 151.86 ns | 154.10 ns | 0.0038 |     320 B |
