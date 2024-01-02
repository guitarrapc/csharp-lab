```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.25 ns** |  **1.679 ns** | **0.092 ns** |  **18.15 ns** |  **18.33 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.62 ns | 28.387 ns | 1.556 ns |  64.15 ns |  67.25 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.12 ns |  0.955 ns | 0.052 ns |  20.08 ns |  20.18 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.81 ns |  0.436 ns | 0.024 ns |  10.79 ns |  10.84 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **183.16 ns** | **12.439 ns** | **0.682 ns** | **182.38 ns** | **183.64 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 693.14 ns | 31.604 ns | 1.732 ns | 691.38 ns | 694.85 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 221.16 ns | 59.512 ns | 3.262 ns | 217.56 ns | 223.92 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.26 ns | 91.512 ns | 5.016 ns | 147.86 ns | 157.02 ns | 0.0038 |     320 B |
