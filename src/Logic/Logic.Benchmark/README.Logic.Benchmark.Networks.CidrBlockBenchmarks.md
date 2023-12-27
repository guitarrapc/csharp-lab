```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean          | Error       | StdDev    | Min           | Max           | Allocated |
|------------------------ |------- |--------------:|------------:|----------:|--------------:|--------------:|----------:|
| **CidrBlockNewString**      | **1**      |    **59.5428 ns** |   **2.6788 ns** | **0.1468 ns** |    **59.4283 ns** |    **59.7083 ns** |         **-** |
| CidrBlockNewBytes       | 1      |     0.0000 ns |   0.0000 ns | 0.0000 ns |     0.0000 ns |     0.0000 ns |         - |
| CidrBlockTryParseString | 1      |    62.3595 ns |   3.1124 ns | 0.1706 ns |    62.2567 ns |    62.5564 ns |         - |
| CidrBlockTryParseBytes  | 1      |     3.0318 ns |   0.0183 ns | 0.0010 ns |     3.0311 ns |     3.0330 ns |         - |
| **CidrBlockNewString**      | **10**     |   **608.8136 ns** |  **66.0763 ns** | **3.6219 ns** |   **606.6472 ns** |   **612.9949 ns** |         **-** |
| CidrBlockNewBytes       | 10     |     2.8458 ns |   0.1097 ns | 0.0060 ns |     2.8407 ns |     2.8524 ns |         - |
| CidrBlockTryParseString | 10     |   667.0706 ns |   5.1331 ns | 0.2814 ns |   666.7468 ns |   667.2553 ns |         - |
| CidrBlockTryParseBytes  | 10     |    28.4968 ns |   0.3082 ns | 0.0169 ns |    28.4851 ns |    28.5162 ns |         - |
| **CidrBlockNewString**      | **100**    | **5,931.8154 ns** |  **57.1668 ns** | **3.1335 ns** | **5,928.7209 ns** | **5,934.9865 ns** |         **-** |
| CidrBlockNewBytes       | 100    |    66.4890 ns |   0.9208 ns | 0.0505 ns |    66.4485 ns |    66.5455 ns |         - |
| CidrBlockTryParseString | 100    | 6,312.4157 ns | 155.5576 ns | 8.5266 ns | 6,306.6248 ns | 6,322.2070 ns |         - |
| CidrBlockTryParseBytes  | 100    |   285.8228 ns |  11.9217 ns | 0.6535 ns |   285.3688 ns |   286.5718 ns |         - |
