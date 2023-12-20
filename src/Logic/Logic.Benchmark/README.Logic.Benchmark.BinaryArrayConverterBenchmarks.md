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
|             **ToBinaryArrayInt** |      **1** |     **18.27 ns** |     **3.585 ns** |   **0.196 ns** |     **18.05 ns** |     **18.42 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     67.65 ns |     5.856 ns |   0.321 ns |     67.46 ns |     68.02 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.71 ns |     7.015 ns |   0.385 ns |     20.28 ns |     21.00 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.59 ns |     0.628 ns |   0.034 ns |     11.55 ns |     11.62 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **187.99 ns** |    **67.322 ns** |   **3.690 ns** |    **184.35 ns** |    **191.73 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    686.97 ns |    54.241 ns |   2.973 ns |    683.65 ns |    689.40 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    208.65 ns |    27.770 ns |   1.522 ns |    206.97 ns |    209.93 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    154.16 ns |    19.938 ns |   1.093 ns |    152.91 ns |    154.92 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,786.62 ns** |   **463.177 ns** |  **25.388 ns** |  **1,764.23 ns** |  **1,814.20 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,174.37 ns |   358.317 ns |  19.641 ns |  7,160.92 ns |  7,196.91 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  1,988.56 ns |   374.641 ns |  20.535 ns |  1,965.11 ns |  2,003.35 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,898.39 ns |   297.424 ns |  16.303 ns |  1,880.40 ns |  1,912.18 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,566.37 ns** |   **577.460 ns** |  **31.653 ns** |  **4,530.59 ns** |  **4,590.72 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,086.21 ns | 4,340.711 ns | 237.929 ns | 16,913.60 ns | 17,357.62 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,203.25 ns |   842.162 ns |  46.162 ns |  5,150.84 ns |  5,237.87 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,020.98 ns | 1,107.313 ns |  60.696 ns |  4,963.69 ns |  5,084.58 ns | 0.0916 |   8,160 B |
