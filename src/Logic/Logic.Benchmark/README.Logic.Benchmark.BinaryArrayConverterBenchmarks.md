```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.78 ns** |   **3.958 ns** | **0.217 ns** |  **18.59 ns** |  **19.02 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.39 ns |  48.585 ns | 2.663 ns |  67.21 ns |  72.36 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.58 ns |   4.005 ns | 0.220 ns |  20.34 ns |  20.77 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.85 ns |   0.827 ns | 0.045 ns |  10.82 ns |  10.90 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **198.04 ns** |  **81.479 ns** | **4.466 ns** | **193.07 ns** | **201.71 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 694.97 ns |  30.875 ns | 1.692 ns | 693.23 ns | 696.61 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 223.24 ns |  46.291 ns | 2.537 ns | 221.65 ns | 226.17 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 146.29 ns | 148.047 ns | 8.115 ns | 141.17 ns | 155.64 ns | 0.0038 |     320 B |
