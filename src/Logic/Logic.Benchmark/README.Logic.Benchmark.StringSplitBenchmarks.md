``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |        Error |    StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|-------------:|----------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **805.2 ns** |     **21.68 ns** |   **1.19 ns** |       **803.9 ns** |       **806.3 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,506.0 ns |    107.04 ns |   5.87 ns |     1,500.8 ns |     1,512.3 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,031.4 ns** |    **169.72 ns** |   **9.30 ns** |     **8,021.7 ns** |     **8,040.2 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,128.4 ns |    724.18 ns |  39.69 ns |    15,104.1 ns |    15,174.2 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,683.4 ns** |  **2,920.69 ns** | **160.09 ns** |    **79,498.9 ns** |    **79,785.3 ns** |       **-** |           **-** |
|        StringSplit |    100 |   147,597.8 ns | 15,401.55 ns | 844.21 ns |   146,763.6 ns |   148,451.7 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **803,824.3 ns** |  **5,813.07 ns** | **318.63 ns** |   **803,475.3 ns** |   **804,099.6 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,448,148.1 ns |  9,243.90 ns | 506.69 ns | 1,447,838.8 ns | 1,448,732.9 ns | 37.1094 | 3,208,001 B |
