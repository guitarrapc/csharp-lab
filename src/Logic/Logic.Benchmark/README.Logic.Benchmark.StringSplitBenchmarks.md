```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **800.5 ns** |  **10.94 ns** |  **0.60 ns** |    **800.0 ns** |    **801.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,489.3 ns | 145.65 ns |  7.98 ns |  1,481.4 ns |  1,497.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,018.8 ns** |  **63.95 ns** |  **3.51 ns** |  **8,015.1 ns** |  **8,022.1 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,700.8 ns | 712.15 ns | 39.04 ns | 14,657.4 ns | 14,732.9 ns | 0.3815 |   32080 B |
