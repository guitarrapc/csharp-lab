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
| **StringSplitNoAlloc** | **1**      |    **800.9 ns** |  **21.96 ns** |  **1.20 ns** |    **799.8 ns** |    **802.2 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,463.3 ns | 101.77 ns |  5.58 ns |  1,458.1 ns |  1,469.2 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,037.5 ns** | **283.27 ns** | **15.53 ns** |  **8,026.8 ns** |  **8,055.3 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,603.4 ns | 706.36 ns | 38.72 ns | 14,577.8 ns | 14,647.9 ns | 0.3815 |   32080 B |
