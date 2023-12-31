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
| **ToBinaryArrayInt**             | **1**      |  **18.78 ns** |   **5.095 ns** | **0.279 ns** |  **18.48 ns** |  **19.04 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.27 ns |   6.437 ns | 0.353 ns |  65.03 ns |  65.67 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.38 ns |   3.600 ns | 0.197 ns |  20.24 ns |  20.60 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.97 ns |   3.384 ns | 0.185 ns |  10.83 ns |  11.18 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **197.95 ns** |  **11.194 ns** | **0.614 ns** | **197.35 ns** | **198.58 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 695.53 ns | 141.872 ns | 7.776 ns | 686.88 ns | 701.96 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 223.51 ns |  36.014 ns | 1.974 ns | 222.35 ns | 225.79 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 155.93 ns |  62.463 ns | 3.424 ns | 153.83 ns | 159.88 ns | 0.0038 |     320 B |
