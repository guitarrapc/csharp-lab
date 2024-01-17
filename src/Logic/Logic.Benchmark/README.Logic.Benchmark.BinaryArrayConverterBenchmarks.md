```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.15 ns** |   **2.266 ns** | **0.124 ns** |  **18.08 ns** |  **18.29 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.74 ns |   1.117 ns | 0.061 ns |  66.69 ns |  66.81 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.79 ns |   4.209 ns | 0.231 ns |  20.54 ns |  20.98 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.28 ns |   0.419 ns | 0.023 ns |  11.26 ns |  11.30 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **195.99 ns** | **145.212 ns** | **7.960 ns** | **187.75 ns** | **203.64 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 711.08 ns | 169.687 ns | 9.301 ns | 703.10 ns | 721.29 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 231.35 ns | 155.332 ns | 8.514 ns | 224.64 ns | 240.93 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 154.76 ns |  40.847 ns | 2.239 ns | 152.57 ns | 157.05 ns | 0.0038 |     320 B |
