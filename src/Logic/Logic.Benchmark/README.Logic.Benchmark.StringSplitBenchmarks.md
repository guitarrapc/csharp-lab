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
| **StringSplitNoAlloc** | **1**      |    **801.2 ns** |  **12.59 ns** |  **0.69 ns** |    **800.4 ns** |    **801.6 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,523.1 ns |  24.13 ns |  1.32 ns |  1,521.7 ns |  1,524.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,024.6 ns** | **247.54 ns** | **13.57 ns** |  **8,009.7 ns** |  **8,036.2 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,812.1 ns | 867.79 ns | 47.57 ns | 14,757.2 ns | 14,840.8 ns | 0.3815 |   32080 B |
