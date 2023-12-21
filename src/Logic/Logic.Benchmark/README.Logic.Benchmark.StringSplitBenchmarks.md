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
| **StringSplitNoAlloc** |      **1** |       **806.7 ns** |     **41.97 ns** |     **2.30 ns** |       **804.1 ns** |       **808.5 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,480.7 ns |     94.99 ns |     5.21 ns |     1,474.9 ns |     1,484.9 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,039.2 ns** |    **208.60 ns** |    **11.43 ns** |     **8,031.9 ns** |     **8,052.4 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,083.2 ns |  1,257.89 ns |    68.95 ns |    15,010.3 ns |    15,147.3 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,674.6 ns** |  **1,286.14 ns** |    **70.50 ns** |    **79,593.8 ns** |    **79,723.5 ns** |       **-** |           **-** |
|        StringSplit |    100 |   144,473.6 ns |  4,986.79 ns |   273.34 ns |   144,158.0 ns |   144,637.9 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **829,558.7 ns** | **41,445.74 ns** | **2,271.78 ns** |   **826,967.2 ns** |   **831,207.0 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,453,172.4 ns | 61,887.72 ns | 3,392.27 ns | 1,450,722.4 ns | 1,457,044.2 ns | 37.1094 | 3,208,001 B |
