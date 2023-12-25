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
|      **CidrBlockNewString** |      **1** |    **64.0144 ns** |   **3.6891 ns** |  **0.2022 ns** |    **63.8659 ns** |    **64.2447 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3093 ns |   0.0073 ns |  0.0004 ns |     0.3088 ns |     0.3097 ns |         - |
| CidrBlockTryParseString |      1 |    65.6243 ns |   4.4533 ns |  0.2441 ns |    65.4760 ns |    65.9061 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1693 ns |   0.2087 ns |  0.0114 ns |     3.1617 ns |     3.1824 ns |         - |
|      **CidrBlockNewString** |     **10** |   **627.6999 ns** | **108.7543 ns** |  **5.9612 ns** |   **620.8166 ns** |   **631.1495 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.8954 ns |   0.1481 ns |  0.0081 ns |     2.8861 ns |     2.9012 ns |         - |
| CidrBlockTryParseString |     10 |   644.9543 ns |  45.4085 ns |  2.4890 ns |   642.3720 ns |   647.3381 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5411 ns |   0.6240 ns |  0.0342 ns |    28.5205 ns |    28.5806 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,983.9456 ns** |  **60.3520 ns** |  **3.3081 ns** | **5,980.5307 ns** | **5,987.1354 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.0653 ns |   5.0782 ns |  0.2784 ns |    68.7592 ns |    69.3033 ns |         - |
| CidrBlockTryParseString |    100 | 6,231.7612 ns | 372.7320 ns | 20.4307 ns | 6,212.1596 ns | 6,252.9307 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.9249 ns |   8.0179 ns |  0.4395 ns |   290.6202 ns |   291.4287 ns |         - |
