``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.19 ns** |     **6.715 ns** |  **0.368 ns** |     **17.85 ns** |     **18.58 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     67.13 ns |    36.555 ns |  2.004 ns |     65.88 ns |     69.44 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.67 ns |     6.145 ns |  0.337 ns |     20.40 ns |     21.05 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.67 ns |     2.386 ns |  0.131 ns |     11.59 ns |     11.82 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **186.05 ns** |    **25.480 ns** |  **1.397 ns** |    **184.44 ns** |    **186.94 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    678.95 ns |    46.322 ns |  2.539 ns |    676.33 ns |    681.40 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    211.19 ns |    46.720 ns |  2.561 ns |    208.67 ns |    213.79 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    155.36 ns |    12.250 ns |  0.671 ns |    154.59 ns |    155.84 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,727.84 ns** |    **49.869 ns** |  **2.733 ns** |  **1,724.69 ns** |  **1,729.67 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,216.97 ns |   224.101 ns | 12.284 ns |  7,205.00 ns |  7,229.54 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  1,974.58 ns |   661.178 ns | 36.241 ns |  1,943.45 ns |  2,014.36 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,855.98 ns |   443.519 ns | 24.311 ns |  1,828.72 ns |  1,875.43 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,558.69 ns** | **1,071.250 ns** | **58.719 ns** |  **4,521.91 ns** |  **4,626.41 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,569.37 ns | 1,479.904 ns | 81.119 ns | 16,509.68 ns | 16,661.73 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,300.62 ns |   458.197 ns | 25.115 ns |  5,280.94 ns |  5,328.91 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,084.31 ns |   961.606 ns | 52.709 ns |  5,049.86 ns |  5,144.99 ns | 0.0916 |   8,160 B |
