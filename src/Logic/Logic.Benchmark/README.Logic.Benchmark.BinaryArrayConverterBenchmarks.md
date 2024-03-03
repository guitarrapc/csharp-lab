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
| **ToBinaryArrayInt**             | **1**      |  **18.87 ns** |   **6.647 ns** | **0.364 ns** |  **18.51 ns** |  **19.24 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.74 ns |   2.310 ns | 0.127 ns |  65.60 ns |  65.83 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.52 ns |   8.379 ns | 0.459 ns |  20.24 ns |  21.05 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.01 ns |   1.073 ns | 0.059 ns |  10.94 ns |  11.06 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **192.96 ns** | **165.068 ns** | **9.048 ns** | **182.95 ns** | **200.54 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 703.59 ns |  41.376 ns | 2.268 ns | 701.49 ns | 706.00 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 227.05 ns |  56.334 ns | 3.088 ns | 223.72 ns | 229.82 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 149.73 ns |  68.760 ns | 3.769 ns | 147.28 ns | 154.07 ns | 0.0038 |     320 B |
