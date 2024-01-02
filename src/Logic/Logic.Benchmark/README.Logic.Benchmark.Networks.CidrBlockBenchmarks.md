```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------------ |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **59.2382 ns** | **1.1844 ns** | **0.0649 ns** |  **59.1702 ns** |  **59.2995 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.0630 ns | 0.5988 ns | 0.0328 ns |  62.0377 ns |  62.1001 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0326 ns | 0.0527 ns | 0.0029 ns |   3.0306 ns |   3.0359 ns |         - |
| **CidrBlockNewString**      | **10**     | **604.7503 ns** | **2.0432 ns** | **0.1120 ns** | **604.6226 ns** | **604.8321 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8447 ns | 0.1066 ns | 0.0058 ns |   2.8411 ns |   2.8514 ns |         - |
| CidrBlockTryParseString | 10     | 636.1479 ns | 4.6898 ns | 0.2571 ns | 635.9427 ns | 636.4363 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.5070 ns | 0.1811 ns | 0.0099 ns |  28.4956 ns |  28.5140 ns |         - |
