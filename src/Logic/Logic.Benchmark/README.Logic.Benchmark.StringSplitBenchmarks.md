```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean           | Error       | StdDev    | Min            | Max            | Gen0    | Allocated |
|------------------- |------- |---------------:|------------:|----------:|---------------:|---------------:|--------:|----------:|
| **StringSplitNoAlloc** | **1**      |       **801.3 ns** |    **19.57 ns** |   **1.07 ns** |       **800.1 ns** |       **802.2 ns** |       **-** |         **-** |
| StringSplit        | 1      |     1,482.7 ns |   333.76 ns |  18.29 ns |     1,471.8 ns |     1,503.9 ns |  0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |     **8,320.6 ns** |   **173.90 ns** |   **9.53 ns** |     **8,314.6 ns** |     **8,331.5 ns** |       **-** |         **-** |
| StringSplit        | 10     |    14,713.5 ns |   120.80 ns |   6.62 ns |    14,707.3 ns |    14,720.5 ns |  0.3815 |   32080 B |
| **StringSplitNoAlloc** | **100**    |    **80,468.6 ns** | **1,044.57 ns** |  **57.26 ns** |    **80,405.3 ns** |    **80,516.7 ns** |       **-** |         **-** |
| StringSplit        | 100    |   147,806.5 ns | 5,129.58 ns | 281.17 ns |   147,508.1 ns |   148,066.4 ns |  3.6621 |  320800 B |
| **StringSplitNoAlloc** | **1000**   |   **802,433.7 ns** | **8,277.59 ns** | **453.72 ns** |   **802,000.4 ns** |   **802,905.4 ns** |       **-** |       **1 B** |
| StringSplit        | 1000   | 1,516,402.2 ns | 7,415.74 ns | 406.48 ns | 1,516,004.7 ns | 1,516,817.1 ns | 37.1094 | 3208001 B |
