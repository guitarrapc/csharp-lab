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
| **ToBinaryArrayInt**             | **1**      |  **18.63 ns** |  **19.557 ns** | **1.072 ns** |  **17.83 ns** |  **19.85 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.02 ns |  21.094 ns | 1.156 ns |  65.13 ns |  67.33 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.48 ns |   5.224 ns | 0.286 ns |  20.15 ns |  20.67 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.79 ns |   0.587 ns | 0.032 ns |  10.76 ns |  10.81 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **199.72 ns** |  **44.136 ns** | **2.419 ns** | **197.93 ns** | **202.47 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 708.06 ns |  27.519 ns | 1.508 ns | 706.60 ns | 709.61 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 233.44 ns | 104.635 ns | 5.735 ns | 226.84 ns | 237.19 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 148.92 ns |  70.572 ns | 3.868 ns | 144.47 ns | 151.50 ns | 0.0038 |     320 B |
