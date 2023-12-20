``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.54 ns** |     **3.254 ns** |   **0.178 ns** |     **18.36 ns** |     **18.71 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     69.32 ns |    34.503 ns |   1.891 ns |     68.19 ns |     71.50 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.38 ns |     5.455 ns |   0.299 ns |     21.12 ns |     21.71 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.53 ns |     0.433 ns |   0.024 ns |     11.50 ns |     11.54 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **186.03 ns** |    **36.873 ns** |   **2.021 ns** |    **183.97 ns** |    **188.01 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    686.53 ns |    20.088 ns |   1.101 ns |    685.56 ns |    687.73 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    207.59 ns |    57.057 ns |   3.127 ns |    205.60 ns |    211.19 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    150.06 ns |    32.931 ns |   1.805 ns |    148.46 ns |    152.02 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,788.68 ns** |   **100.271 ns** |   **5.496 ns** |  **1,782.82 ns** |  **1,793.73 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,156.63 ns |   351.290 ns |  19.255 ns |  7,139.46 ns |  7,177.45 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,011.49 ns |   547.271 ns |  29.998 ns |  1,984.16 ns |  2,043.59 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,856.62 ns |   637.280 ns |  34.931 ns |  1,831.03 ns |  1,896.42 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,426.38 ns** |   **232.295 ns** |  **12.733 ns** |  **4,415.48 ns** |  **4,440.37 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,818.21 ns | 3,009.147 ns | 164.941 ns | 16,711.90 ns | 17,008.22 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  4,959.65 ns |   219.378 ns |  12.025 ns |  4,947.68 ns |  4,971.73 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,045.92 ns |   949.261 ns |  52.032 ns |  4,997.84 ns |  5,101.16 ns | 0.0916 |   8,160 B |
