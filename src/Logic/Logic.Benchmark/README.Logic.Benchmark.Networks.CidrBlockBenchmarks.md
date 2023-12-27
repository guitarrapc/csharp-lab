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
| **CidrBlockNewString**      | **1**      |  **59.4448 ns** | **2.5936 ns** | **0.1422 ns** |  **59.3551 ns** |  **59.6087 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.2610 ns | 1.3648 ns | 0.0748 ns |  62.1819 ns |  62.3306 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0401 ns | 0.0547 ns | 0.0030 ns |   3.0367 ns |   3.0423 ns |         - |
| **CidrBlockNewString**      | **10**     | **671.1794 ns** | **3.0090 ns** | **0.1649 ns** | **671.0118 ns** | **671.3415 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8435 ns | 0.0037 ns | 0.0002 ns |   2.8434 ns |   2.8438 ns |         - |
| CidrBlockTryParseString | 10     | 633.4042 ns | 3.3206 ns | 0.1820 ns | 633.2364 ns | 633.5977 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.6040 ns | 3.0748 ns | 0.1685 ns |  28.4733 ns |  28.7943 ns |         - |
