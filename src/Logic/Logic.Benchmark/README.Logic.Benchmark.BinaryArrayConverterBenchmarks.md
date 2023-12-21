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
|             **ToBinaryArrayInt** |      **1** |     **18.64 ns** |     **2.568 ns** |   **0.141 ns** |     **18.48 ns** |     **18.76 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     69.52 ns |    21.148 ns |   1.159 ns |     68.34 ns |     70.66 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.51 ns |     7.306 ns |   0.400 ns |     21.07 ns |     21.86 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.68 ns |     0.780 ns |   0.043 ns |     11.65 ns |     11.73 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **193.70 ns** |     **5.111 ns** |   **0.280 ns** |    **193.41 ns** |    **193.97 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    680.41 ns |    54.145 ns |   2.968 ns |    677.97 ns |    683.72 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    209.44 ns |    67.795 ns |   3.716 ns |    205.86 ns |    213.28 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    152.37 ns |    19.107 ns |   1.047 ns |    151.34 ns |    153.43 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,765.22 ns** |   **890.756 ns** |  **48.825 ns** |  **1,727.38 ns** |  **1,820.34 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,233.07 ns |   213.432 ns |  11.699 ns |  7,226.21 ns |  7,246.58 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,008.67 ns | 1,289.971 ns |  70.708 ns |  1,938.81 ns |  2,080.20 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,853.78 ns |   298.976 ns |  16.388 ns |  1,843.43 ns |  1,872.68 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,443.81 ns** |   **556.642 ns** |  **30.511 ns** |  **4,409.83 ns** |  **4,468.86 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,059.90 ns | 6,520.158 ns | 357.392 ns | 16,849.49 ns | 17,472.55 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,017.23 ns | 1,924.172 ns | 105.470 ns |  4,934.76 ns |  5,136.08 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,147.81 ns | 1,331.523 ns |  72.985 ns |  5,086.62 ns |  5,228.59 ns | 0.0916 |   8,160 B |
