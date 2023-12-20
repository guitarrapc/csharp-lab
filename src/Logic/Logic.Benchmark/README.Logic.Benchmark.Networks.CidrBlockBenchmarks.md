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
|      **CidrBlockNewString** |      **1** |    **60.4468 ns** |   **0.4410 ns** | **0.0242 ns** |    **60.4219 ns** |    **60.4702 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3085 ns |   0.0024 ns | 0.0001 ns |     0.3083 ns |     0.3086 ns |         - |
| CidrBlockTryParseString |      1 |    66.6364 ns |  57.1442 ns | 3.1323 ns |    64.8210 ns |    70.2532 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.2525 ns |   1.3432 ns | 0.0736 ns |     3.1675 ns |     3.2952 ns |         - |
|      **CidrBlockNewString** |     **10** |   **598.9617 ns** |   **7.8041 ns** | **0.4278 ns** |   **598.5003 ns** |   **599.3450 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9027 ns |   0.1664 ns | 0.0091 ns |     2.8931 ns |     2.9113 ns |         - |
| CidrBlockTryParseString |     10 |   626.3834 ns |  17.4555 ns | 0.9568 ns |   625.4063 ns |   627.3185 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5267 ns |   0.2765 ns | 0.0152 ns |    28.5180 ns |    28.5442 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,918.8385 ns** | **108.9953 ns** | **5.9744 ns** | **5,914.9640 ns** | **5,925.7189 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    68.9987 ns |   2.0720 ns | 0.1136 ns |    68.9091 ns |    69.1264 ns |         - |
| CidrBlockTryParseString |    100 | 6,271.3927 ns |  77.9536 ns | 4.2729 ns | 6,267.7459 ns | 6,276.0942 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.4015 ns |   2.9909 ns | 0.1639 ns |   290.2716 ns |   290.5857 ns |         - |
