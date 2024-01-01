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
| **ToBinaryArrayInt**             | **1**      |  **18.98 ns** |   **4.341 ns** | **0.238 ns** |  **18.77 ns** |  **19.24 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.93 ns |   6.450 ns | 0.354 ns |  65.68 ns |  66.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.77 ns |  12.347 ns | 0.677 ns |  20.10 ns |  21.45 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |   2.471 ns | 0.135 ns |  10.97 ns |  11.21 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **183.02 ns** | **115.252 ns** | **6.317 ns** | **175.73 ns** | **186.91 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 693.70 ns |  24.507 ns | 1.343 ns | 692.87 ns | 695.25 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 217.37 ns |  23.448 ns | 1.285 ns | 215.90 ns | 218.31 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.20 ns | 106.542 ns | 5.840 ns | 144.61 ns | 155.72 ns | 0.0038 |     320 B |
