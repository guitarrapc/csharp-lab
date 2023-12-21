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
|      **CidrBlockNewString** |      **1** |    **60.7684 ns** |   **0.8049 ns** |  **0.0441 ns** |    **60.7214 ns** |    **60.8089 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3089 ns |   0.0160 ns |  0.0009 ns |     0.3083 ns |     0.3099 ns |         - |
| CidrBlockTryParseString |      1 |    66.2161 ns |  25.8121 ns |  1.4149 ns |    65.3733 ns |    67.8496 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.3085 ns |   0.2454 ns |  0.0135 ns |     3.2931 ns |     3.3182 ns |         - |
|      **CidrBlockNewString** |     **10** |   **621.0622 ns** |  **18.7044 ns** |  **1.0253 ns** |   **620.3531 ns** |   **622.2378 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.8993 ns |   0.1736 ns |  0.0095 ns |     2.8906 ns |     2.9094 ns |         - |
| CidrBlockTryParseString |     10 |   628.2754 ns |   4.3630 ns |  0.2392 ns |   628.0000 ns |   628.4300 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5451 ns |   0.1650 ns |  0.0090 ns |    28.5357 ns |    28.5537 ns |         - |
|      **CidrBlockNewString** |    **100** | **6,200.6292 ns** | **237.9711 ns** | **13.0440 ns** | **6,186.6902 ns** | **6,212.5409 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.0068 ns |   3.4339 ns |  0.1882 ns |    68.8041 ns |    69.1761 ns |         - |
| CidrBlockTryParseString |    100 | 6,207.8985 ns | 353.3251 ns | 19.3669 ns | 6,185.5444 ns | 6,219.6218 ns |         - |
|  CidrBlockTryParseBytes |    100 |   291.3103 ns |  27.3577 ns |  1.4996 ns |   290.1890 ns |   293.0136 ns |         - |
