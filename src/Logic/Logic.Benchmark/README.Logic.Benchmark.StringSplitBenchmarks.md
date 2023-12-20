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
| **StringSplitNoAlloc** |      **1** |       **804.8 ns** |     **34.04 ns** |     **1.87 ns** |       **802.6 ns** |       **805.9 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,522.2 ns |    375.04 ns |    20.56 ns |     1,504.0 ns |     1,544.5 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,026.3 ns** |     **76.18 ns** |     **4.18 ns** |     **8,021.5 ns** |     **8,029.2 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,118.4 ns |  1,220.37 ns |    66.89 ns |    15,077.2 ns |    15,195.6 ns |  0.3662 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **80,358.5 ns** |  **1,969.81 ns** |   **107.97 ns** |    **80,234.1 ns** |    **80,428.1 ns** |       **-** |           **-** |
|        StringSplit |    100 |   146,149.1 ns | 17,489.07 ns |   958.63 ns |   145,440.5 ns |   147,239.9 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **800,225.4 ns** | **26,597.14 ns** | **1,457.88 ns** |   **799,032.1 ns** |   **801,850.3 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,487,228.2 ns | 37,194.22 ns | 2,038.74 ns | 1,485,180.0 ns | 1,489,257.4 ns | 37.1094 | 3,208,001 B |
