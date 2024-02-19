```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.69 ns** |  **8.718 ns** | **0.478 ns** |  **18.32 ns** |  **19.23 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.65 ns | 15.585 ns | 0.854 ns |  64.76 ns |  66.46 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.29 ns |  2.584 ns | 0.142 ns |  20.19 ns |  20.45 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.81 ns |  0.892 ns | 0.049 ns |  10.78 ns |  10.86 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **200.02 ns** | **47.491 ns** | **2.603 ns** | **197.81 ns** | **202.89 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 676.96 ns | 23.005 ns | 1.261 ns | 675.76 ns | 678.27 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 234.10 ns | 75.799 ns | 4.155 ns | 230.60 ns | 238.69 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 149.11 ns | 39.914 ns | 2.188 ns | 146.87 ns | 151.24 ns | 0.0038 |     320 B |
