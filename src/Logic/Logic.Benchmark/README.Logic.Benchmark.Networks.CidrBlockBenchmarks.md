``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |         Error |      StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|--------------:|------------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **62.6628 ns** |     **2.6061 ns** |   **0.1428 ns** |    **62.4986 ns** |    **62.7586 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3116 ns |     0.0819 ns |   0.0045 ns |     0.3086 ns |     0.3168 ns |         - |
| CidrBlockTryParseString |      1 |    62.5686 ns |     1.1482 ns |   0.0629 ns |    62.5000 ns |    62.6237 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1681 ns |     0.1487 ns |   0.0081 ns |     3.1615 ns |     3.1772 ns |         - |
|      **CidrBlockNewString** |     **10** |   **597.5186 ns** |     **4.8031 ns** |   **0.2633 ns** |   **597.2523 ns** |   **597.7787 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9032 ns |     0.0991 ns |   0.0054 ns |     2.8971 ns |     2.9077 ns |         - |
| CidrBlockTryParseString |     10 |   648.9678 ns |    20.1293 ns |   1.1034 ns |   647.8581 ns |   650.0647 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5362 ns |     0.0673 ns |   0.0037 ns |    28.5328 ns |    28.5401 ns |         - |
|      **CidrBlockNewString** |    **100** | **6,258.6716 ns** | **2,304.1632 ns** | **126.2990 ns** | **6,181.2295 ns** | **6,404.4135 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.0166 ns |     1.8877 ns |   0.1035 ns |    68.9262 ns |    69.1295 ns |         - |
| CidrBlockTryParseString |    100 | 6,248.2728 ns |   100.3593 ns |   5.5010 ns | 6,243.1625 ns | 6,254.0952 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.1973 ns |     1.5807 ns |   0.0866 ns |   290.0976 ns |   290.2543 ns |         - |
