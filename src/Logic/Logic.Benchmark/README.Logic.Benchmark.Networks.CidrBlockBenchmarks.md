```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **60.5316 ns** |  **0.5818 ns** | **0.0319 ns** |  **60.4948 ns** |  **60.5509 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.1849 ns |  0.8056 ns | 0.0442 ns |  62.1469 ns |  62.2333 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0367 ns |  0.0854 ns | 0.0047 ns |   3.0319 ns |   3.0413 ns |         - |
| **CidrBlockNewString**      | **10**     | **604.6814 ns** |  **0.7889 ns** | **0.0432 ns** | **604.6365 ns** | **604.7228 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8470 ns |  0.1109 ns | 0.0061 ns |   2.8425 ns |   2.8539 ns |         - |
| CidrBlockTryParseString | 10     | 641.3633 ns | 35.5436 ns | 1.9483 ns | 639.8813 ns | 643.5701 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.4722 ns |  0.1031 ns | 0.0057 ns |  28.4665 ns |  28.4778 ns |         - |
