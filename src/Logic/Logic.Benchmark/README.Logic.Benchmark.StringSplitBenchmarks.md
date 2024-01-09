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
| **StringSplitNoAlloc** | **1**      |    **797.9 ns** |  **14.29 ns** |  **0.78 ns** |    **797.1 ns** |    **798.6 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,452.2 ns | 183.21 ns | 10.04 ns |  1,445.6 ns |  1,463.7 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,019.9 ns** | **101.61 ns** |  **5.57 ns** |  **8,015.0 ns** |  **8,026.0 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,036.4 ns | 703.33 ns | 38.55 ns | 15,004.5 ns | 15,079.2 ns | 0.3815 |   32080 B |
