``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |         Error |      StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|--------------:|------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **804.1 ns** |       **8.92 ns** |     **0.49 ns** |       **803.6 ns** |       **804.5 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,482.5 ns |      61.30 ns |     3.36 ns |     1,480.1 ns |     1,486.3 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,029.0 ns** |      **70.28 ns** |     **3.85 ns** |     **8,025.8 ns** |     **8,033.3 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,140.8 ns |     934.19 ns |    51.21 ns |    15,083.1 ns |    15,180.7 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,766.9 ns** |   **1,763.76 ns** |    **96.68 ns** |    **79,685.3 ns** |    **79,873.7 ns** |       **-** |           **-** |
|        StringSplit |    100 |   146,364.6 ns |  30,485.26 ns | 1,671.00 ns |   145,317.9 ns |   148,291.7 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **805,288.9 ns** |  **23,107.70 ns** | **1,266.61 ns** |   **803,829.0 ns** |   **806,094.7 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,487,688.9 ns | 102,916.03 ns | 5,641.17 ns | 1,482,246.7 ns | 1,493,509.9 ns | 37.1094 | 3,208,001 B |
