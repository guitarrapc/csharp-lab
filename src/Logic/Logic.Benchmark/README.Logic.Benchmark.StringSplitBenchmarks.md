``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |        Error |      StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|-------------:|------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **833.6 ns** |     **18.01 ns** |     **0.99 ns** |       **832.9 ns** |       **834.8 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,511.9 ns |    130.03 ns |     7.13 ns |     1,503.7 ns |     1,516.6 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,060.7 ns** |  **1,156.37 ns** |    **63.38 ns** |     **8,019.6 ns** |     **8,133.7 ns** |       **-** |           **-** |
|        StringSplit |     10 |    14,944.6 ns |  5,525.79 ns |   302.89 ns |    14,751.6 ns |    15,293.7 ns |  0.3662 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,701.4 ns** |    **607.87 ns** |    **33.32 ns** |    **79,664.9 ns** |    **79,730.3 ns** |       **-** |           **-** |
|        StringSplit |    100 |   149,678.1 ns | 10,153.38 ns |   556.54 ns |   149,095.1 ns |   150,203.7 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **796,302.8 ns** |  **8,642.83 ns** |   **473.74 ns** |   **795,786.7 ns** |   **796,717.9 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,499,917.6 ns | 72,631.59 ns | 3,981.18 ns | 1,495,493.2 ns | 1,503,210.8 ns | 37.1094 | 3,208,001 B |
