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
| **StringSplitNoAlloc** |      **1** |       **805.3 ns** |      **23.57 ns** |     **1.29 ns** |       **804.2 ns** |       **806.7 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,517.5 ns |      51.98 ns |     2.85 ns |     1,515.4 ns |     1,520.8 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,031.4 ns** |     **314.20 ns** |    **17.22 ns** |     **8,013.8 ns** |     **8,048.3 ns** |       **-** |           **-** |
|        StringSplit |     10 |    14,862.7 ns |     424.17 ns |    23.25 ns |    14,837.0 ns |    14,882.1 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,612.2 ns** |     **775.12 ns** |    **42.49 ns** |    **79,566.9 ns** |    **79,651.1 ns** |       **-** |           **-** |
|        StringSplit |    100 |   149,610.8 ns |  13,855.30 ns |   759.46 ns |   148,939.6 ns |   150,435.1 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **802,764.8 ns** |  **42,717.52 ns** | **2,341.49 ns** |   **800,805.7 ns** |   **805,358.1 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,441,729.5 ns | 121,894.52 ns | 6,681.45 ns | 1,436,394.6 ns | 1,449,223.5 ns | 37.1094 | 3,208,001 B |
