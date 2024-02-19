```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **843.2 ns** |    **51.38 ns** |   **2.82 ns** |    **841.4 ns** |    **846.5 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,557.5 ns | 1,950.35 ns | 106.91 ns |  1,495.6 ns |  1,680.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,372.4 ns** |   **684.37 ns** |  **37.51 ns** |  **8,340.3 ns** |  **8,413.6 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,493.3 ns | 1,147.46 ns |  62.90 ns | 14,443.4 ns | 14,563.9 ns | 0.3815 |   32080 B |
