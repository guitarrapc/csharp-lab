``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **59.7979 ns** |   **6.4273 ns** |  **0.3523 ns** |    **59.5412 ns** |    **60.1996 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3092 ns |   0.0230 ns |  0.0013 ns |     0.3085 ns |     0.3107 ns |         - |
| CidrBlockTryParseString |      1 |    67.1236 ns |  29.4759 ns |  1.6157 ns |    66.0591 ns |    68.9827 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.3038 ns |   0.1781 ns |  0.0098 ns |     3.2953 ns |     3.3145 ns |         - |
|      **CidrBlockNewString** |     **10** |   **601.0827 ns** |  **45.1260 ns** |  **2.4735 ns** |   **599.5642 ns** |   **603.9369 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9046 ns |   0.0782 ns |  0.0043 ns |     2.8997 ns |     2.9073 ns |         - |
| CidrBlockTryParseString |     10 |   627.9650 ns |   7.0444 ns |  0.3861 ns |   627.5612 ns |   628.3307 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5416 ns |   0.6501 ns |  0.0356 ns |    28.5160 ns |    28.5823 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,938.5901 ns** | **360.3630 ns** | **19.7527 ns** | **5,926.2299 ns** | **5,961.3711 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.0833 ns |   1.5905 ns |  0.0872 ns |    68.9974 ns |    69.1717 ns |         - |
| CidrBlockTryParseString |    100 | 6,215.5825 ns |  15.2901 ns |  0.8381 ns | 6,214.7851 ns | 6,216.4561 ns |         - |
|  CidrBlockTryParseBytes |    100 |   291.0241 ns |  10.5249 ns |  0.5769 ns |   290.3584 ns |   291.3780 ns |         - |
