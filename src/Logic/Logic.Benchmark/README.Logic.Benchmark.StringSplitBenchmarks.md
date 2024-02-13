```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **823.4 ns** |   **155.0 ns** |   **8.50 ns** |    **813.6 ns** |    **828.8 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,436.6 ns |   111.4 ns |   6.10 ns |  1,430.3 ns |  1,442.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,242.8 ns** | **2,379.4 ns** | **130.42 ns** |  **8,094.9 ns** |  **8,341.2 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,331.8 ns | 1,641.8 ns |  89.99 ns | 14,246.1 ns | 14,425.6 ns | 0.3815 |   32080 B |
