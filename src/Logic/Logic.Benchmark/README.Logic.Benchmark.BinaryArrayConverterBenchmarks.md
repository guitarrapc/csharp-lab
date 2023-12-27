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
| **ToBinaryArrayInt**             | **1**      |  **17.90 ns** |   **6.975 ns** | **0.382 ns** |  **17.48 ns** |  **18.23 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.88 ns |   3.813 ns | 0.209 ns |  65.72 ns |  66.11 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.72 ns |   6.389 ns | 0.350 ns |  20.33 ns |  21.01 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.74 ns |   0.166 ns | 0.009 ns |  10.73 ns |  10.75 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **177.75 ns** | **159.898 ns** | **8.765 ns** | **172.34 ns** | **187.87 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 701.00 ns |  16.023 ns | 0.878 ns | 700.02 ns | 701.72 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 224.95 ns |  95.612 ns | 5.241 ns | 220.40 ns | 230.68 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 153.08 ns |  38.018 ns | 2.084 ns | 151.45 ns | 155.43 ns | 0.0038 |     320 B |
