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
| **ToBinaryArrayInt**             | **1**      |  **19.95 ns** |  **16.799 ns** |  **0.921 ns** |  **18.88 ns** |  **20.50 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.21 ns |  32.434 ns |  1.778 ns |  65.45 ns |  69.01 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.32 ns |   5.645 ns |  0.309 ns |  20.03 ns |  20.65 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.82 ns |   1.313 ns |  0.072 ns |  10.74 ns |  10.88 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **186.94 ns** | **112.704 ns** |  **6.178 ns** | **180.08 ns** | **192.06 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 697.09 ns | 242.243 ns | 13.278 ns | 682.77 ns | 709.00 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 225.77 ns |  77.730 ns |  4.261 ns | 222.50 ns | 230.59 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 144.82 ns |  72.270 ns |  3.961 ns | 141.62 ns | 149.25 ns | 0.0038 |     320 B |
