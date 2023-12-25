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
| **StringSplitNoAlloc** |      **1** |       **805.7 ns** |      **42.24 ns** |      **2.32 ns** |       **803.2 ns** |       **807.7 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,482.4 ns |      73.97 ns |      4.05 ns |     1,478.5 ns |     1,486.6 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,040.4 ns** |     **288.85 ns** |     **15.83 ns** |     **8,023.1 ns** |     **8,054.2 ns** |       **-** |           **-** |
|        StringSplit |     10 |    14,878.1 ns |     954.89 ns |     52.34 ns |    14,819.5 ns |    14,920.0 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,757.3 ns** |     **914.26 ns** |     **50.11 ns** |    **79,700.5 ns** |    **79,795.5 ns** |       **-** |           **-** |
|        StringSplit |    100 |   153,709.5 ns |  22,077.76 ns |  1,210.16 ns |   152,351.7 ns |   154,674.2 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **800,959.3 ns** |  **16,980.70 ns** |    **930.77 ns** |   **799,920.3 ns** |   **801,717.0 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,487,534.7 ns | 207,380.14 ns | 11,367.21 ns | 1,475,331.0 ns | 1,497,821.7 ns | 37.1094 | 3,208,001 B |
