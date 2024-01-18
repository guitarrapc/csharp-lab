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
| **ToBinaryArrayInt**             | **1**      |  **21.46 ns** |  **47.074 ns** | **2.580 ns** |  **18.48 ns** |  **22.98 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.97 ns |   5.517 ns | 0.302 ns |  66.78 ns |  67.32 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.46 ns |   8.402 ns | 0.461 ns |  20.95 ns |  21.83 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.85 ns |   1.821 ns | 0.100 ns |  10.76 ns |  10.96 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **203.22 ns** | **133.416 ns** | **7.313 ns** | **195.81 ns** | **210.43 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 753.23 ns |  27.318 ns | 1.497 ns | 751.53 ns | 754.36 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 231.02 ns |  24.294 ns | 1.332 ns | 229.60 ns | 232.25 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 146.03 ns |  11.303 ns | 0.620 ns | 145.56 ns | 146.73 ns | 0.0038 |     320 B |
