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
| **ToBinaryArrayInt**             | **1**      |     **18.57 ns** |     **4.890 ns** |   **0.268 ns** |     **18.34 ns** |     **18.86 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |     66.07 ns |     4.014 ns |   0.220 ns |     65.93 ns |     66.32 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |     20.78 ns |    13.518 ns |   0.741 ns |     20.28 ns |     21.63 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |     10.50 ns |     0.999 ns |   0.055 ns |     10.46 ns |     10.56 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     |    **195.26 ns** |   **151.677 ns** |   **8.314 ns** |    **186.51 ns** |    **203.06 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     |    692.34 ns |    30.363 ns |   1.664 ns |    690.87 ns |    694.15 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     |    224.02 ns |    43.100 ns |   2.362 ns |    222.08 ns |    226.65 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     |    154.51 ns |    26.617 ns |   1.459 ns |    153.33 ns |    156.14 ns | 0.0038 |     320 B |
| **ToBinaryArrayInt**             | **100**    |  **1,737.58 ns** |   **110.510 ns** |   **6.057 ns** |  **1,731.63 ns** |  **1,743.74 ns** | **0.0381** |    **3200 B** |
| ToBinaryArrayConvertToString | 100    |  7,085.38 ns |    65.285 ns |   3.579 ns |  7,081.45 ns |  7,088.46 ns | 0.1297 |   10928 B |
| ToBinaryArrayIntMod          | 100    |  2,210.38 ns |   415.916 ns |  22.798 ns |  2,188.27 ns |  2,233.81 ns | 0.0381 |    3200 B |
| ToBinaryArrayIntModNumber    | 100    |  2,053.36 ns |   624.831 ns |  34.249 ns |  2,018.48 ns |  2,086.94 ns | 0.0381 |    3200 B |
| **ToBinaryArrayInt**             | **255**    |  **4,725.10 ns** | **5,295.328 ns** | **290.255 ns** |  **4,390.53 ns** |  **4,909.54 ns** | **0.0916** |    **8160 B** |
| ToBinaryArrayConvertToString | 255    | 17,151.36 ns | 1,002.921 ns |  54.974 ns | 17,091.34 ns | 17,199.26 ns | 0.2747 |   23208 B |
| ToBinaryArrayIntMod          | 255    |  5,438.93 ns | 3,643.108 ns | 199.691 ns |  5,300.76 ns |  5,667.88 ns | 0.0916 |    8160 B |
| ToBinaryArrayIntModNumber    | 255    |  5,512.99 ns | 1,310.768 ns |  71.848 ns |  5,441.76 ns |  5,585.44 ns | 0.0916 |    8160 B |
