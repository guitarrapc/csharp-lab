``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |         Mean |         Error |     StdDev |          Min |          Max | Allocated |
|------------------------ |------- |-------------:|--------------:|-----------:|-------------:|-------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **74.787 ns** |     **2.9172 ns** |  **0.1599 ns** |    **74.678 ns** |    **74.970 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     2.156 ns |     0.1977 ns |  0.0108 ns |     2.147 ns |     2.168 ns |         - |
| CidrBlockTryParseString |      1 |    79.923 ns |     3.6967 ns |  0.2026 ns |    79.752 ns |    80.147 ns |         - |
|  CidrBlockTryParseBytes |      1 |     9.851 ns |     0.0420 ns |  0.0023 ns |     9.848 ns |     9.853 ns |         - |
|      **CidrBlockNewString** |     **10** |   **758.523 ns** |    **33.7566 ns** |  **1.8503 ns** |   **756.484 ns** |   **760.097 ns** |         **-** |
|       CidrBlockNewBytes |     10 |    24.842 ns |     0.5967 ns |  0.0327 ns |    24.820 ns |    24.879 ns |         - |
| CidrBlockTryParseString |     10 |   813.151 ns |   213.5397 ns | 11.7048 ns |   806.295 ns |   826.667 ns |         - |
|  CidrBlockTryParseBytes |     10 |   110.417 ns |     2.3359 ns |  0.1280 ns |   110.339 ns |   110.565 ns |         - |
|      **CidrBlockNewString** |    **100** | **7,624.835 ns** |    **79.2727 ns** |  **4.3452 ns** | **7,621.502 ns** | **7,629.750 ns** |         **-** |
|       CidrBlockNewBytes |    100 |   253.398 ns |     1.5409 ns |  0.0845 ns |   253.307 ns |   253.474 ns |         - |
| CidrBlockTryParseString |    100 | 8,028.552 ns | 1,505.2514 ns | 82.5079 ns | 7,974.156 ns | 8,123.487 ns |         - |
|  CidrBlockTryParseBytes |    100 | 1,051.882 ns |    17.1761 ns |  0.9415 ns | 1,051.145 ns | 1,052.943 ns |         - |
