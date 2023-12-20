``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |    StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **59.8864 ns** |   **0.5641 ns** | **0.0309 ns** |    **59.8591 ns** |    **59.9200 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3088 ns |   0.0027 ns | 0.0001 ns |     0.3086 ns |     0.3089 ns |         - |
| CidrBlockTryParseString |      1 |    63.2428 ns |   1.3169 ns | 0.0722 ns |    63.1784 ns |    63.3208 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.3104 ns |   0.1567 ns | 0.0086 ns |     3.3024 ns |     3.3195 ns |         - |
|      **CidrBlockNewString** |     **10** |   **625.0561 ns** |  **22.5213 ns** | **1.2345 ns** |   **623.7876 ns** |   **626.2534 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.8962 ns |   0.1340 ns | 0.0073 ns |     2.8902 ns |     2.9044 ns |         - |
| CidrBlockTryParseString |     10 |   628.4105 ns |  17.0076 ns | 0.9322 ns |   627.5410 ns |   629.3948 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5344 ns |   0.2100 ns | 0.0115 ns |    28.5218 ns |    28.5443 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,934.8892 ns** | **151.2075 ns** | **8.2882 ns** | **5,929.1363 ns** | **5,944.3893 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.1267 ns |   1.7193 ns | 0.0942 ns |    69.0195 ns |    69.1967 ns |         - |
| CidrBlockTryParseString |    100 | 6,190.6776 ns | 164.3546 ns | 9.0088 ns | 6,181.9688 ns | 6,199.9591 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.2355 ns |   2.8298 ns | 0.1551 ns |   290.0706 ns |   290.3785 ns |         - |
