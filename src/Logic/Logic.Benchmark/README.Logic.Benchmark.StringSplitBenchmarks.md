``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |         Error |       StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|--------------:|-------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **803.4 ns** |      **23.20 ns** |      **1.27 ns** |       **802.2 ns** |       **804.7 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,525.4 ns |     407.49 ns |     22.34 ns |     1,501.5 ns |     1,545.8 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,043.9 ns** |     **687.77 ns** |     **37.70 ns** |     **8,017.4 ns** |     **8,087.1 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,391.9 ns |  10,834.25 ns |    593.86 ns |    15,027.1 ns |    16,077.2 ns |  0.3662 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,701.8 ns** |     **959.86 ns** |     **52.61 ns** |    **79,641.1 ns** |    **79,735.2 ns** |       **-** |           **-** |
|        StringSplit |    100 |   146,191.5 ns |  20,574.57 ns |  1,127.76 ns |   144,891.1 ns |   146,902.0 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **798,785.9 ns** |  **34,181.76 ns** |  **1,873.62 ns** |   **796,711.2 ns** |   **800,354.4 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,458,653.0 ns | 260,152.25 ns | 14,259.82 ns | 1,450,053.8 ns | 1,475,113.3 ns | 37.1094 | 3,208,001 B |
