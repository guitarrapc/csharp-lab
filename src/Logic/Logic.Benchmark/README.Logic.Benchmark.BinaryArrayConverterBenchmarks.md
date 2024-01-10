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
| **ToBinaryArrayInt**             | **1**      |  **18.58 ns** |  **1.871 ns** | **0.103 ns** |  **18.47 ns** |  **18.66 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.72 ns |  2.706 ns | 0.148 ns |  66.56 ns |  66.86 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.50 ns |  5.386 ns | 0.295 ns |  20.16 ns |  20.70 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  2.606 ns | 0.143 ns |  10.84 ns |  11.09 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **188.15 ns** | **26.536 ns** | **1.455 ns** | **186.53 ns** | **189.35 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 693.89 ns | 30.194 ns | 1.655 ns | 692.80 ns | 695.79 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 237.25 ns | 32.477 ns | 1.780 ns | 235.55 ns | 239.10 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 153.26 ns | 17.895 ns | 0.981 ns | 152.18 ns | 154.10 ns | 0.0038 |     320 B |
