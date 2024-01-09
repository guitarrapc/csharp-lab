```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.73 ns** |  **7.228 ns** | **0.396 ns** |  **17.29 ns** |  **18.07 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.68 ns |  7.119 ns | 0.390 ns |  64.41 ns |  65.12 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.48 ns |  1.024 ns | 0.056 ns |  20.42 ns |  20.53 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.03 ns |  3.335 ns | 0.183 ns |  10.88 ns |  11.23 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **178.27 ns** | **87.814 ns** | **4.813 ns** | **172.72 ns** | **181.08 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 693.93 ns |  5.474 ns | 0.300 ns | 693.58 ns | 694.10 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 231.75 ns | 21.936 ns | 1.202 ns | 230.44 ns | 232.79 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 152.68 ns | 57.757 ns | 3.166 ns | 149.86 ns | 156.10 ns | 0.0038 |     320 B |
