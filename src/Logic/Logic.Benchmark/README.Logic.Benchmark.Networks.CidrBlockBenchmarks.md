``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |      Error |    StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|-----------:|----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **64.2289 ns** |  **9.3808 ns** | **0.5142 ns** |    **63.6352 ns** |    **64.5322 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3087 ns |  0.0246 ns | 0.0013 ns |     0.3078 ns |     0.3102 ns |         - |
| CidrBlockTryParseString |      1 |    62.8871 ns |  2.1921 ns | 0.1202 ns |    62.7863 ns |    63.0201 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1641 ns |  0.0386 ns | 0.0021 ns |     3.1624 ns |     3.1665 ns |         - |
|      **CidrBlockNewString** |     **10** |   **612.1249 ns** |  **3.9030 ns** | **0.2139 ns** |   **611.9119 ns** |   **612.3397 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.8886 ns |  0.0847 ns | 0.0046 ns |     2.8832 ns |     2.8914 ns |         - |
| CidrBlockTryParseString |     10 |   646.8853 ns | 10.9972 ns | 0.6028 ns |   646.3241 ns |   647.5224 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5556 ns |  0.7498 ns | 0.0411 ns |    28.5207 ns |    28.6009 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,914.4598 ns** | **37.5949 ns** | **2.0607 ns** | **5,913.0257 ns** | **5,916.8212 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    68.9999 ns |  1.2368 ns | 0.0678 ns |    68.9315 ns |    69.0670 ns |         - |
| CidrBlockTryParseString |    100 | 6,348.5848 ns | 91.3480 ns | 5.0071 ns | 6,345.0735 ns | 6,354.3184 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.0641 ns |  0.9716 ns | 0.0533 ns |   290.0026 ns |   290.0968 ns |         - |
