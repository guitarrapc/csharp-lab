``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |         Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|--------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **60.8929 ns** |    **10.0154 ns** |  **0.5490 ns** |    **60.5716 ns** |    **61.5268 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3094 ns |     0.0201 ns |  0.0011 ns |     0.3087 ns |     0.3107 ns |         - |
| CidrBlockTryParseString |      1 |    63.6233 ns |     1.6715 ns |  0.0916 ns |    63.5441 ns |    63.7237 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1715 ns |     0.1953 ns |  0.0107 ns |     3.1620 ns |     3.1831 ns |         - |
|      **CidrBlockNewString** |     **10** |   **599.7861 ns** |    **10.4422 ns** |  **0.5724 ns** |   **599.4396 ns** |   **600.4468 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9033 ns |     0.2821 ns |  0.0155 ns |     2.8927 ns |     2.9210 ns |         - |
| CidrBlockTryParseString |     10 |   632.5563 ns |    62.1516 ns |  3.4067 ns |   630.2264 ns |   636.4661 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.6780 ns |     0.1626 ns |  0.0089 ns |    28.6678 ns |    28.6846 ns |         - |
|      **CidrBlockNewString** |    **100** | **6,190.8563 ns** | **1,176.7197 ns** | **64.5000 ns** | **6,138.7637 ns** | **6,263.0005 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.1378 ns |     3.4045 ns |  0.1866 ns |    68.9877 ns |    69.3468 ns |         - |
| CidrBlockTryParseString |    100 | 6,395.0865 ns |    65.7497 ns |  3.6040 ns | 6,392.6344 ns | 6,399.2245 ns |         - |
|  CidrBlockTryParseBytes |    100 |   299.6002 ns |   254.2706 ns | 13.9374 ns |   290.0784 ns |   315.5973 ns |         - |
