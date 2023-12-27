```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean         | Error        | StdDev     | Min          | Max          | Gen0   | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |     **19.12 ns** |     **2.191 ns** |   **0.120 ns** |     **19.01 ns** |     **19.25 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |     67.00 ns |    15.853 ns |   0.869 ns |     66.32 ns |     67.98 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |     20.63 ns |     4.327 ns |   0.237 ns |     20.36 ns |     20.78 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |     10.90 ns |     0.676 ns |   0.037 ns |     10.86 ns |     10.93 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     |    **199.42 ns** |   **122.864 ns** |   **6.735 ns** |    **191.79 ns** |    **204.51 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     |    703.38 ns |    12.644 ns |   0.693 ns |    702.80 ns |    704.15 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     |    226.40 ns |    93.235 ns |   5.111 ns |    222.19 ns |    232.09 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     |    157.66 ns |    36.403 ns |   1.995 ns |    156.34 ns |    159.95 ns | 0.0038 |     320 B |
| **ToBinaryArrayInt**             | **100**    |  **1,747.56 ns** |   **238.922 ns** |  **13.096 ns** |  **1,732.54 ns** |  **1,756.60 ns** | **0.0381** |    **3200 B** |
| ToBinaryArrayConvertToString | 100    |  7,172.61 ns |   210.419 ns |  11.534 ns |  7,159.87 ns |  7,182.35 ns | 0.1297 |   10928 B |
| ToBinaryArrayIntMod          | 100    |  2,169.32 ns |   609.047 ns |  33.384 ns |  2,136.82 ns |  2,203.52 ns | 0.0381 |    3200 B |
| ToBinaryArrayIntModNumber    | 100    |  1,989.57 ns |   170.877 ns |   9.366 ns |  1,981.36 ns |  1,999.77 ns | 0.0381 |    3200 B |
| **ToBinaryArrayInt**             | **255**    |  **4,827.00 ns** | **1,944.641 ns** | **106.592 ns** |  **4,751.95 ns** |  **4,949.01 ns** | **0.0916** |    **8160 B** |
| ToBinaryArrayConvertToString | 255    | 17,503.22 ns | 2,977.763 ns | 163.221 ns | 17,377.05 ns | 17,687.56 ns | 0.2747 |   23208 B |
| ToBinaryArrayIntMod          | 255    |  5,474.20 ns | 1,311.405 ns |  71.883 ns |  5,424.89 ns |  5,556.68 ns | 0.0916 |    8160 B |
| ToBinaryArrayIntModNumber    | 255    |  5,518.83 ns | 1,895.027 ns | 103.873 ns |  5,404.00 ns |  5,606.26 ns | 0.0916 |    8160 B |
