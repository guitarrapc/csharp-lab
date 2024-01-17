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
| **ToBinaryArrayInt**             | **1**      |  **18.21 ns** |   **7.716 ns** | **0.423 ns** |  **17.75 ns** |  **18.58 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.91 ns |   4.037 ns | 0.221 ns |  65.69 ns |  66.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.10 ns |   5.805 ns | 0.318 ns |  20.82 ns |  21.44 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.11 ns |   1.640 ns | 0.090 ns |  11.04 ns |  11.21 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **192.79 ns** |  **58.393 ns** | **3.201 ns** | **190.93 ns** | **196.48 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 710.21 ns |  62.957 ns | 3.451 ns | 706.37 ns | 713.05 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 216.93 ns | 146.149 ns | 8.011 ns | 210.49 ns | 225.90 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 158.04 ns |  43.471 ns | 2.383 ns | 156.38 ns | 160.77 ns | 0.0038 |     320 B |
