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
| **StringSplitNoAlloc** | **1**      |    **833.3 ns** |  **11.31 ns** |  **0.62 ns** |    **832.7 ns** |    **833.9 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,456.9 ns |  90.14 ns |  4.94 ns |  1,451.6 ns |  1,461.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,365.8 ns** | **522.89 ns** | **28.66 ns** |  **8,346.5 ns** |  **8,398.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,026.9 ns | 690.98 ns | 37.88 ns | 14,987.1 ns | 15,062.5 ns | 0.3815 |   32080 B |
