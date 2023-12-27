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
| **ToBinaryArrayInt**             | **1**      |     **18.49 ns** |     **5.504 ns** |   **0.302 ns** |     **18.14 ns** |     **18.69 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |     65.47 ns |     4.372 ns |   0.240 ns |     65.30 ns |     65.75 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |     20.56 ns |     5.365 ns |   0.294 ns |     20.38 ns |     20.90 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |     10.92 ns |     1.421 ns |   0.078 ns |     10.83 ns |     10.98 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     |    **196.73 ns** |    **51.245 ns** |   **2.809 ns** |    **194.06 ns** |    **199.66 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     |    690.82 ns |   168.234 ns |   9.221 ns |    684.84 ns |    701.44 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     |    225.73 ns |   116.883 ns |   6.407 ns |    218.94 ns |    231.67 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     |    155.10 ns |    16.463 ns |   0.902 ns |    154.12 ns |    155.90 ns | 0.0038 |     320 B |
| **ToBinaryArrayInt**             | **100**    |  **1,738.53 ns** |    **85.606 ns** |   **4.692 ns** |  **1,733.22 ns** |  **1,742.12 ns** | **0.0381** |    **3200 B** |
| ToBinaryArrayConvertToString | 100    |  7,255.38 ns |   499.333 ns |  27.370 ns |  7,230.45 ns |  7,284.66 ns | 0.1297 |   10928 B |
| ToBinaryArrayIntMod          | 100    |  2,132.50 ns |   895.611 ns |  49.091 ns |  2,097.05 ns |  2,188.53 ns | 0.0381 |    3200 B |
| ToBinaryArrayIntModNumber    | 100    |  2,007.00 ns |   423.005 ns |  23.186 ns |  1,984.21 ns |  2,030.57 ns | 0.0381 |    3200 B |
| **ToBinaryArrayInt**             | **255**    |  **4,388.75 ns** |   **151.791 ns** |   **8.320 ns** |  **4,382.25 ns** |  **4,398.13 ns** | **0.0916** |    **8160 B** |
| ToBinaryArrayConvertToString | 255    | 17,068.11 ns | 4,048.878 ns | 221.933 ns | 16,917.92 ns | 17,323.03 ns | 0.2747 |   23208 B |
| ToBinaryArrayIntMod          | 255    |  5,532.87 ns |   629.298 ns |  34.494 ns |  5,496.66 ns |  5,565.34 ns | 0.0916 |    8160 B |
| ToBinaryArrayIntModNumber    | 255    |  5,454.78 ns |   542.766 ns |  29.751 ns |  5,435.79 ns |  5,489.07 ns | 0.0916 |    8160 B |
