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
|      **CidrBlockNewString** |      **1** |    **62.3569 ns** |   **0.9234 ns** | **0.0506 ns** |    **62.2985 ns** |    **62.3866 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3090 ns |   0.0025 ns | 0.0001 ns |     0.3088 ns |     0.3091 ns |         - |
| CidrBlockTryParseString |      1 |    65.8936 ns |  10.1851 ns | 0.5583 ns |    65.4888 ns |    66.5305 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.3088 ns |   0.1216 ns | 0.0067 ns |     3.3038 ns |     3.3163 ns |         - |
|      **CidrBlockNewString** |     **10** |   **621.2975 ns** |   **3.2480 ns** | **0.1780 ns** |   **621.1215 ns** |   **621.4775 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9070 ns |   0.0342 ns | 0.0019 ns |     2.9056 ns |     2.9092 ns |         - |
| CidrBlockTryParseString |     10 |   628.8001 ns |  22.8453 ns | 1.2522 ns |   627.5639 ns |   630.0677 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5355 ns |   0.2480 ns | 0.0136 ns |    28.5249 ns |    28.5508 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,981.0555 ns** | **148.8207 ns** | **8.1574 ns** | **5,974.4977 ns** | **5,990.1901 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.2092 ns |   3.9876 ns | 0.2186 ns |    69.0665 ns |    69.4608 ns |         - |
| CidrBlockTryParseString |    100 | 6,216.6390 ns | 139.0631 ns | 7.6225 ns | 6,210.2518 ns | 6,225.0772 ns |         - |
|  CidrBlockTryParseBytes |    100 |   289.9372 ns |   0.7185 ns | 0.0394 ns |   289.9138 ns |   289.9826 ns |         - |
