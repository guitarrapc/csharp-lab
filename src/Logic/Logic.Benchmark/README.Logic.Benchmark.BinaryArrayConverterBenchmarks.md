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
| **ToBinaryArrayInt**             | **1**      |  **18.35 ns** |  **5.006 ns** | **0.274 ns** |  **18.04 ns** |  **18.57 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.88 ns | 40.326 ns | 2.210 ns |  65.51 ns |  69.43 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.91 ns | 10.949 ns | 0.600 ns |  20.40 ns |  21.57 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.91 ns |  0.861 ns | 0.047 ns |  10.86 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **193.29 ns** | **80.320 ns** | **4.403 ns** | **190.35 ns** | **198.35 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.70 ns | 48.743 ns | 2.672 ns | 692.68 ns | 697.76 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 234.98 ns | 64.779 ns | 3.551 ns | 230.95 ns | 237.65 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 150.86 ns | 45.632 ns | 2.501 ns | 148.58 ns | 153.54 ns | 0.0038 |     320 B |
