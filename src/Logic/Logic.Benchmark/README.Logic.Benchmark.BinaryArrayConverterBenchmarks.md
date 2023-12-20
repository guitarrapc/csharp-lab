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
|             **ToBinaryArrayInt** |      **1** |     **18.69 ns** |     **5.679 ns** |   **0.311 ns** |     **18.33 ns** |     **18.90 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     66.67 ns |     2.866 ns |   0.157 ns |     66.52 ns |     66.83 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.74 ns |     5.176 ns |   0.284 ns |     20.44 ns |     21.00 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.57 ns |     0.950 ns |   0.052 ns |     11.53 ns |     11.63 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **189.14 ns** |    **66.123 ns** |   **3.624 ns** |    **185.01 ns** |    **191.77 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    671.46 ns |    48.178 ns |   2.641 ns |    669.93 ns |    674.51 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    211.57 ns |    41.523 ns |   2.276 ns |    210.25 ns |    214.20 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    155.10 ns |    27.166 ns |   1.489 ns |    153.93 ns |    156.77 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,802.22 ns** | **1,416.973 ns** |  **77.669 ns** |  **1,723.97 ns** |  **1,879.29 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,105.21 ns |   541.758 ns |  29.696 ns |  7,085.23 ns |  7,139.34 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,003.57 ns |   702.665 ns |  38.515 ns |  1,959.19 ns |  2,028.28 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,856.51 ns |   285.247 ns |  15.635 ns |  1,838.55 ns |  1,867.08 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,496.60 ns** |   **420.152 ns** |  **23.030 ns** |  **4,474.54 ns** |  **4,520.49 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,732.85 ns | 5,635.152 ns | 308.882 ns | 16,515.39 ns | 17,086.41 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,080.76 ns | 2,817.670 ns | 154.446 ns |  4,980.11 ns |  5,258.58 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,100.06 ns | 1,033.680 ns |  56.660 ns |  5,034.91 ns |  5,137.77 ns | 0.0916 |   8,160 B |
