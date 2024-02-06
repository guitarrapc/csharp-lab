```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **842.7 ns** |  **33.07 ns** |  **1.81 ns** |    **841.2 ns** |    **844.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,516.0 ns | 232.25 ns | 12.73 ns |  1,505.3 ns |  1,530.1 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,410.6 ns** |   **0.88 ns** |  **0.05 ns** |  **8,410.6 ns** |  **8,410.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,538.9 ns | 729.44 ns | 39.98 ns | 14,504.2 ns | 14,582.6 ns | 0.3815 |   32080 B |
