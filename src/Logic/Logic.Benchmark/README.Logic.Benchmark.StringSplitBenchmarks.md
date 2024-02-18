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
| **StringSplitNoAlloc** | **1**      |    **834.7 ns** |    **25.54 ns** |   **1.40 ns** |    **833.3 ns** |    **836.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,456.2 ns |    96.90 ns |   5.31 ns |  1,451.3 ns |  1,461.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,344.9 ns** |   **104.23 ns** |   **5.71 ns** |  **8,338.6 ns** |  **8,349.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,605.5 ns | 2,458.54 ns | 134.76 ns | 14,500.7 ns | 14,757.6 ns | 0.3815 |   32080 B |
