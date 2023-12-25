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
|             **ToBinaryArrayInt** |      **1** |     **19.54 ns** |    **13.513 ns** |   **0.741 ns** |     **18.72 ns** |     **20.17 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     66.82 ns |     7.082 ns |   0.388 ns |     66.54 ns |     67.26 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.88 ns |     2.756 ns |   0.151 ns |     20.71 ns |     21.01 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.67 ns |     1.532 ns |   0.084 ns |     11.62 ns |     11.77 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **189.56 ns** |    **49.421 ns** |   **2.709 ns** |    **187.17 ns** |    **192.50 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    681.52 ns |   114.091 ns |   6.254 ns |    675.69 ns |    688.12 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    209.53 ns |     9.268 ns |   0.508 ns |    208.95 ns |    209.89 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    156.48 ns |   103.898 ns |   5.695 ns |    151.07 ns |    162.42 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,746.67 ns** |   **454.200 ns** |  **24.896 ns** |  **1,731.54 ns** |  **1,775.40 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,352.01 ns |   445.276 ns |  24.407 ns |  7,327.14 ns |  7,375.93 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,070.78 ns |   519.254 ns |  28.462 ns |  2,040.79 ns |  2,097.42 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,810.04 ns |   127.404 ns |   6.983 ns |  1,805.14 ns |  1,818.03 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,479.41 ns** | **2,506.657 ns** | **137.398 ns** |  **4,397.04 ns** |  **4,638.03 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,294.13 ns |   977.598 ns |  53.585 ns | 17,250.74 ns | 17,354.03 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,003.41 ns |   503.160 ns |  27.580 ns |  4,971.59 ns |  5,020.32 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,114.11 ns |   357.354 ns |  19.588 ns |  5,099.68 ns |  5,136.41 ns | 0.0916 |   8,160 B |
