```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error       | StdDev     | Median      | Min         | Max         | Allocated |
|------------------------ |------- |------------:|------------:|-----------:|------------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **60.1417 ns** |   **2.7938 ns** |  **0.1531 ns** |  **60.1305 ns** |  **59.9944 ns** |  **60.3001 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0002 ns |   0.0050 ns |  0.0003 ns |   0.0000 ns |   0.0000 ns |   0.0005 ns |         - |
| CidrBlockTryParseString | 1      |  62.4941 ns |   1.0684 ns |  0.0586 ns |  62.5121 ns |  62.4287 ns |  62.5416 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0422 ns |   0.1300 ns |  0.0071 ns |   3.0403 ns |   3.0361 ns |   3.0500 ns |         - |
| **CidrBlockNewString**      | **10**     | **610.0613 ns** | **248.8231 ns** | **13.6388 ns** | **607.9893 ns** | **597.5770 ns** | **624.6176 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8540 ns |   0.0789 ns |  0.0043 ns |   2.8524 ns |   2.8508 ns |   2.8589 ns |         - |
| CidrBlockTryParseString | 10     | 636.4965 ns |   7.1087 ns |  0.3897 ns | 636.7010 ns | 636.0472 ns | 636.7413 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.2130 ns |   0.2775 ns |  0.0152 ns |  28.2184 ns |  28.1958 ns |  28.2247 ns |         - |
