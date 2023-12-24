``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |      Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.18 ns** |   **2.310 ns** |  **0.127 ns** |     **18.03 ns** |     **18.27 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     66.18 ns |   1.379 ns |  0.076 ns |     66.09 ns |     66.22 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.71 ns |   4.097 ns |  0.225 ns |     20.45 ns |     20.87 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.75 ns |   6.563 ns |  0.360 ns |     11.53 ns |     12.17 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **188.38 ns** |  **27.451 ns** |  **1.505 ns** |    **186.66 ns** |    **189.47 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    677.49 ns |  23.972 ns |  1.314 ns |    676.28 ns |    678.89 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    206.38 ns |  15.722 ns |  0.862 ns |    205.40 ns |    207.00 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    154.59 ns |   5.550 ns |  0.304 ns |    154.26 ns |    154.87 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,723.18 ns** | **414.900 ns** | **22.742 ns** |  **1,708.50 ns** |  **1,749.37 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,122.56 ns | 207.367 ns | 11.366 ns |  7,110.97 ns |  7,133.69 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  1,940.64 ns | 269.767 ns | 14.787 ns |  1,928.31 ns |  1,957.03 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,852.14 ns | 569.360 ns | 31.209 ns |  1,818.12 ns |  1,879.44 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,367.88 ns** | **500.840 ns** | **27.453 ns** |  **4,350.12 ns** |  **4,399.50 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,710.68 ns | 829.791 ns | 45.484 ns | 16,679.56 ns | 16,762.88 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,116.23 ns | 186.820 ns | 10.240 ns |  5,105.00 ns |  5,125.06 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,077.22 ns |  77.063 ns |  4.224 ns |  5,072.74 ns |  5,081.14 ns | 0.0916 |   8,160 B |
