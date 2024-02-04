```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **840.9 ns** |     **7.27 ns** |   **0.40 ns** |    **840.5 ns** |    **841.2 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,464.3 ns |   129.01 ns |   7.07 ns |  1,459.3 ns |  1,472.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,416.7 ns** |   **212.21 ns** |  **11.63 ns** |  **8,403.8 ns** |  **8,426.4 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,203.9 ns | 1,838.88 ns | 100.80 ns | 15,129.1 ns | 15,318.5 ns | 0.3815 |   32080 B |
