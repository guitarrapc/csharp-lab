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
| **ToBinaryArrayInt**             | **1**      |  **21.80 ns** |  **9.866 ns** | **0.541 ns** |  **21.41 ns** |  **22.42 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.04 ns |  9.348 ns | 0.512 ns |  65.57 ns |  66.58 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.42 ns |  4.486 ns | 0.246 ns |  20.16 ns |  20.65 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.07 ns |  2.387 ns | 0.131 ns |  10.99 ns |  11.22 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **182.55 ns** | **93.958 ns** | **5.150 ns** | **179.45 ns** | **188.49 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 691.11 ns | 14.301 ns | 0.784 ns | 690.24 ns | 691.77 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 230.20 ns | 55.435 ns | 3.039 ns | 226.72 ns | 232.32 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 153.69 ns | 48.447 ns | 2.656 ns | 150.96 ns | 156.26 ns | 0.0038 |     320 B |
