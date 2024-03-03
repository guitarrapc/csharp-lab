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
| **StringSplitNoAlloc** | **1**      |    **834.6 ns** |  **50.01 ns** |  **2.74 ns** |    **832.7 ns** |    **837.8 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,535.0 ns | 325.41 ns | 17.84 ns |  1,520.4 ns |  1,554.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,375.4 ns** | **788.66 ns** | **43.23 ns** |  **8,345.4 ns** |  **8,424.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,775.6 ns | 525.44 ns | 28.80 ns | 14,758.6 ns | 14,808.9 ns | 0.3815 |   32080 B |
