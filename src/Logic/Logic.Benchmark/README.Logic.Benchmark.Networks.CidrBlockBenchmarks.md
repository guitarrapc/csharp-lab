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
| **CidrBlockNewString**      | **1**      |    **59.4567 ns** |   **4.1479 ns** |  **0.2274 ns** |    **59.3138 ns** |    **59.7189 ns** |         **-** |
| CidrBlockNewBytes       | 1      |     0.0000 ns |   0.0000 ns |  0.0000 ns |     0.0000 ns |     0.0000 ns |         - |
| CidrBlockTryParseString | 1      |    62.2645 ns |   0.4390 ns |  0.0241 ns |    62.2383 ns |    62.2856 ns |         - |
| CidrBlockTryParseBytes  | 1      |     3.1092 ns |   2.0927 ns |  0.1147 ns |     3.0318 ns |     3.2410 ns |         - |
| **CidrBlockNewString**      | **10**     |   **616.4061 ns** |  **36.2316 ns** |  **1.9860 ns** |   **615.1818 ns** |   **618.6975 ns** |         **-** |
| CidrBlockNewBytes       | 10     |     2.8579 ns |   0.2248 ns |  0.0123 ns |     2.8466 ns |     2.8711 ns |         - |
| CidrBlockTryParseString | 10     |   642.7792 ns |  74.0760 ns |  4.0604 ns |   639.6208 ns |   647.3592 ns |         - |
| CidrBlockTryParseBytes  | 10     |    28.4836 ns |   1.6602 ns |  0.0910 ns |    28.4222 ns |    28.5881 ns |         - |
| **CidrBlockNewString**      | **100**    | **5,980.4379 ns** | **240.1074 ns** | **13.1611 ns** | **5,965.2467 ns** | **5,988.4023 ns** |         **-** |
| CidrBlockNewBytes       | 100    |    66.3776 ns |   4.4101 ns |  0.2417 ns |    66.1351 ns |    66.6185 ns |         - |
| CidrBlockTryParseString | 100    | 6,241.9565 ns |  69.2229 ns |  3.7943 ns | 6,239.4459 ns | 6,246.3214 ns |         - |
| CidrBlockTryParseBytes  | 100    |   285.5394 ns |   5.5930 ns |  0.3066 ns |   285.3416 ns |   285.8926 ns |         - |
