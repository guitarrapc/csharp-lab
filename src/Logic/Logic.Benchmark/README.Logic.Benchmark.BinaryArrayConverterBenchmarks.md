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
| **ToBinaryArrayInt**             | **1**      |  **18.23 ns** |  **2.204 ns** | **0.121 ns** |  **18.10 ns** |  **18.32 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.76 ns |  4.955 ns | 0.272 ns |  67.52 ns |  68.06 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.80 ns |  9.396 ns | 0.515 ns |  20.40 ns |  21.38 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.21 ns |  0.689 ns | 0.038 ns |  11.17 ns |  11.24 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **188.13 ns** | **57.139 ns** | **3.132 ns** | **184.61 ns** | **190.61 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.36 ns | 47.919 ns | 2.627 ns | 692.46 ns | 697.59 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 238.55 ns | 12.555 ns | 0.688 ns | 237.90 ns | 239.27 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 160.13 ns | 12.988 ns | 0.712 ns | 159.44 ns | 160.86 ns | 0.0038 |     320 B |
