```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean          | Error       | StdDev     | Min           | Max           | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
| **CidrBlockNewString**      | **1**      |    **59.6957 ns** |   **1.9090 ns** |  **0.1046 ns** |    **59.6240 ns** |    **59.8158 ns** |         **-** |
| CidrBlockNewBytes       | 1      |     0.0000 ns |   0.0000 ns |  0.0000 ns |     0.0000 ns |     0.0000 ns |         - |
| CidrBlockTryParseString | 1      |    62.3823 ns |   2.2040 ns |  0.1208 ns |    62.2432 ns |    62.4613 ns |         - |
| CidrBlockTryParseBytes  | 1      |     3.0674 ns |   0.1321 ns |  0.0072 ns |     3.0601 ns |     3.0746 ns |         - |
| **CidrBlockNewString**      | **10**     |   **614.1927 ns** |  **17.8615 ns** |  **0.9790 ns** |   **613.1240 ns** |   **615.0463 ns** |         **-** |
| CidrBlockNewBytes       | 10     |     2.8477 ns |   0.1165 ns |  0.0064 ns |     2.8427 ns |     2.8549 ns |         - |
| CidrBlockTryParseString | 10     |   638.4762 ns | 245.4973 ns | 13.4565 ns |   630.0466 ns |   653.9952 ns |         - |
| CidrBlockTryParseBytes  | 10     |    28.5529 ns |   1.6761 ns |  0.0919 ns |    28.4826 ns |    28.6569 ns |         - |
| **CidrBlockNewString**      | **100**    | **6,063.7609 ns** | **792.1965 ns** | **43.4230 ns** | **6,035.8834 ns** | **6,113.7924 ns** |         **-** |
| CidrBlockNewBytes       | 100    |    66.1501 ns |   0.4824 ns |  0.0264 ns |    66.1233 ns |    66.1762 ns |         - |
| CidrBlockTryParseString | 100    | 6,282.7049 ns |  36.6534 ns |  2.0091 ns | 6,280.5488 ns | 6,284.5245 ns |         - |
| CidrBlockTryParseBytes  | 100    |   296.0088 ns |   4.9465 ns |  0.2711 ns |   295.8491 ns |   296.3219 ns |         - |
