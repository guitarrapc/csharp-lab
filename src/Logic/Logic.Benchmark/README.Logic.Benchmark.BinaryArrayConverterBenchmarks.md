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
| **ToBinaryArrayInt**             | **1**      |  **18.32 ns** |   **6.665 ns** | **0.365 ns** |  **17.92 ns** |  **18.64 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.03 ns |   1.227 ns | 0.067 ns |  65.99 ns |  66.11 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.50 ns |   4.101 ns | 0.225 ns |  20.30 ns |  20.74 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.95 ns |   0.868 ns | 0.048 ns |  10.89 ns |  10.98 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **184.51 ns** |  **43.828 ns** | **2.402 ns** | **181.78 ns** | **186.30 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 687.63 ns |  21.811 ns | 1.196 ns | 686.29 ns | 688.59 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 224.66 ns | 119.249 ns | 6.536 ns | 220.62 ns | 232.20 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 152.48 ns |  43.888 ns | 2.406 ns | 150.67 ns | 155.21 ns | 0.0038 |     320 B |
