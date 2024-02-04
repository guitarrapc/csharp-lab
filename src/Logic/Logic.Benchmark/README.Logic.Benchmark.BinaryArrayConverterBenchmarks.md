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
| **ToBinaryArrayInt**             | **1**      |  **18.98 ns** |   **2.665 ns** | **0.146 ns** |  **18.82 ns** |  **19.10 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.57 ns |   1.102 ns | 0.060 ns |  67.50 ns |  67.61 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.75 ns |   5.459 ns | 0.299 ns |  20.41 ns |  20.99 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.31 ns |   0.896 ns | 0.049 ns |  11.25 ns |  11.34 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **182.72 ns** |  **66.925 ns** | **3.668 ns** | **178.65 ns** | **185.78 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 704.41 ns |  85.209 ns | 4.671 ns | 700.97 ns | 709.73 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 227.09 ns | 110.057 ns | 6.033 ns | 220.52 ns | 232.38 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 147.48 ns |  22.363 ns | 1.226 ns | 146.76 ns | 148.90 ns | 0.0038 |     320 B |
