```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean           | Error        | StdDev      | Min            | Max            | Gen0    | Allocated |
|------------------- |------- |---------------:|-------------:|------------:|---------------:|---------------:|--------:|----------:|
| **StringSplitNoAlloc** | **1**      |       **798.7 ns** |     **14.20 ns** |     **0.78 ns** |       **798.0 ns** |       **799.5 ns** |       **-** |         **-** |
| StringSplit        | 1      |     1,633.4 ns |    120.03 ns |     6.58 ns |     1,626.3 ns |     1,639.4 ns |  0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |     **8,014.9 ns** |    **112.94 ns** |     **6.19 ns** |     **8,007.7 ns** |     **8,018.7 ns** |       **-** |         **-** |
| StringSplit        | 10     |    14,608.3 ns |    179.33 ns |     9.83 ns |    14,600.4 ns |    14,619.3 ns |  0.3815 |   32080 B |
| **StringSplitNoAlloc** | **100**    |    **79,918.8 ns** |  **2,235.65 ns** |   **122.54 ns** |    **79,834.2 ns** |    **80,059.3 ns** |       **-** |         **-** |
| StringSplit        | 100    |   145,711.5 ns | 13,630.35 ns |   747.13 ns |   145,275.2 ns |   146,574.2 ns |  3.6621 |  320800 B |
| **StringSplitNoAlloc** | **1000**   |   **795,796.7 ns** | **12,098.30 ns** |   **663.15 ns** |   **795,135.3 ns** |   **796,461.6 ns** |       **-** |       **1 B** |
| StringSplit        | 1000   | 1,472,923.6 ns | 63,731.39 ns | 3,493.33 ns | 1,470,591.0 ns | 1,476,939.9 ns | 37.1094 | 3208001 B |
