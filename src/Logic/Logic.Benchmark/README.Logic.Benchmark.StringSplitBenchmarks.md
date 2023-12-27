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
| **StringSplitNoAlloc** | **1**      |       **800.5 ns** |      **9.81 ns** |     **0.54 ns** |       **799.9 ns** |       **801.0 ns** |       **-** |         **-** |
| StringSplit        | 1      |     1,595.8 ns |     42.35 ns |     2.32 ns |     1,593.1 ns |     1,597.4 ns |  0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |     **8,022.2 ns** |    **148.50 ns** |     **8.14 ns** |     **8,016.7 ns** |     **8,031.5 ns** |       **-** |         **-** |
| StringSplit        | 10     |    14,759.4 ns |    321.57 ns |    17.63 ns |    14,739.2 ns |    14,771.6 ns |  0.3815 |   32080 B |
| **StringSplitNoAlloc** | **100**    |    **80,612.6 ns** |  **7,504.19 ns** |   **411.33 ns** |    **80,303.8 ns** |    **81,079.5 ns** |       **-** |         **-** |
| StringSplit        | 100    |   150,757.5 ns | 11,220.71 ns |   615.05 ns |   150,099.1 ns |   151,317.2 ns |  3.6621 |  320800 B |
| **StringSplitNoAlloc** | **1000**   |   **801,937.6 ns** |  **3,506.69 ns** |   **192.21 ns** |   **801,798.1 ns** |   **802,156.9 ns** |       **-** |       **1 B** |
| StringSplit        | 1000   | 1,473,900.4 ns | 33,417.32 ns | 1,831.72 ns | 1,472,461.3 ns | 1,475,962.3 ns | 37.1094 | 3208001 B |
