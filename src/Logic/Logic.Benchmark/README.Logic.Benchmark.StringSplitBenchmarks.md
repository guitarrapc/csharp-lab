```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **834.8 ns** |    **25.53 ns** |  **1.40 ns** |    **833.2 ns** |    **835.9 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,494.2 ns |    38.61 ns |  2.12 ns |  1,492.5 ns |  1,496.6 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,342.5 ns** |   **139.63 ns** |  **7.65 ns** |  **8,334.0 ns** |  **8,348.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,833.7 ns | 1,194.93 ns | 65.50 ns | 14,786.3 ns | 14,908.4 ns | 0.3815 |   32080 B |
