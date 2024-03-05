```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **838.2 ns** |   **0.93 ns** |  **0.05 ns** |    **838.1 ns** |    **838.2 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,475.8 ns | 819.80 ns | 44.94 ns |  1,449.5 ns |  1,527.7 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,419.0 ns** | **285.19 ns** | **15.63 ns** |  **8,401.6 ns** |  **8,431.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,550.4 ns | 962.19 ns | 52.74 ns | 14,493.3 ns | 14,597.3 ns | 0.3815 |   32080 B |
