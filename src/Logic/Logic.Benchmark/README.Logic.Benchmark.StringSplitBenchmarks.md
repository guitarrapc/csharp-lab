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
| **StringSplitNoAlloc** |      **1** |       **805.3 ns** |      **24.46 ns** |      **1.34 ns** |       **804.0 ns** |       **806.7 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,487.1 ns |      35.31 ns |      1.94 ns |     1,485.9 ns |     1,489.3 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,109.9 ns** |     **969.86 ns** |     **53.16 ns** |     **8,048.6 ns** |     **8,141.5 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,183.7 ns |     954.63 ns |     52.33 ns |    15,146.1 ns |    15,243.4 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,702.3 ns** |   **2,509.97 ns** |    **137.58 ns** |    **79,560.1 ns** |    **79,834.8 ns** |       **-** |           **-** |
|        StringSplit |    100 |   151,660.4 ns |  13,667.45 ns |    749.16 ns |   150,997.4 ns |   152,473.1 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **802,948.6 ns** |   **3,331.25 ns** |    **182.60 ns** |   **802,765.7 ns** |   **803,130.9 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,497,920.8 ns | 353,895.95 ns | 19,398.23 ns | 1,481,415.8 ns | 1,519,287.4 ns | 37.1094 | 3,208,001 B |
