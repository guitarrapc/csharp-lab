```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **837.0 ns** |  **30.34 ns** |  **1.66 ns** |    **835.2 ns** |    **838.4 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,458.5 ns | 164.17 ns |  9.00 ns |  1,448.1 ns |  1,463.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,791.8 ns** | **141.72 ns** |  **7.77 ns** |  **8,783.0 ns** |  **8,797.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,869.6 ns | 716.45 ns | 39.27 ns | 14,829.6 ns | 14,908.1 ns | 0.3815 |   32080 B |
