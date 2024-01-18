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
| **ToBinaryArrayInt**             | **1**      |  **18.00 ns** |  **10.813 ns** | **0.593 ns** |  **17.57 ns** |  **18.68 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.63 ns |   1.247 ns | 0.068 ns |  66.58 ns |  66.71 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.73 ns |   9.738 ns | 0.534 ns |  20.35 ns |  21.34 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.89 ns |   0.831 ns | 0.046 ns |  10.84 ns |  10.93 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **203.07 ns** |  **25.283 ns** | **1.386 ns** | **201.97 ns** | **204.63 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 696.61 ns |   9.922 ns | 0.544 ns | 696.00 ns | 697.05 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 221.27 ns | 163.060 ns | 8.938 ns | 214.62 ns | 231.43 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 164.03 ns |  62.689 ns | 3.436 ns | 160.26 ns | 166.99 ns | 0.0038 |     320 B |
