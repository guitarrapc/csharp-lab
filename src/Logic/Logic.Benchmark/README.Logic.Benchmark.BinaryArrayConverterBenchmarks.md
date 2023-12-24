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
|             **ToBinaryArrayInt** |      **1** |     **18.53 ns** |     **4.639 ns** |   **0.254 ns** |     **18.24 ns** |     **18.71 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     68.04 ns |    26.780 ns |   1.468 ns |     67.13 ns |     69.73 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.07 ns |     2.425 ns |   0.133 ns |     20.97 ns |     21.22 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.65 ns |     0.638 ns |   0.035 ns |     11.61 ns |     11.68 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **179.52 ns** |    **33.049 ns** |   **1.812 ns** |    **177.43 ns** |    **180.70 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    684.18 ns |    32.904 ns |   1.804 ns |    682.72 ns |    686.19 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    205.77 ns |    32.402 ns |   1.776 ns |    204.63 ns |    207.82 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    158.39 ns |    24.389 ns |   1.337 ns |    156.86 ns |    159.30 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,737.15 ns** |   **653.723 ns** |  **35.833 ns** |  **1,711.89 ns** |  **1,778.16 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,166.65 ns |   308.306 ns |  16.899 ns |  7,148.13 ns |  7,181.23 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  1,933.92 ns |   114.393 ns |   6.270 ns |  1,928.51 ns |  1,940.79 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,825.97 ns |   279.154 ns |  15.301 ns |  1,812.01 ns |  1,842.33 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,514.88 ns** |   **592.207 ns** |  **32.461 ns** |  **4,486.44 ns** |  **4,550.24 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,690.67 ns | 4,030.771 ns | 220.940 ns | 16,518.62 ns | 16,939.83 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,085.00 ns |   456.862 ns |  25.042 ns |  5,065.32 ns |  5,113.19 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,082.48 ns |   507.909 ns |  27.840 ns |  5,051.28 ns |  5,104.81 ns | 0.0916 |   8,160 B |
