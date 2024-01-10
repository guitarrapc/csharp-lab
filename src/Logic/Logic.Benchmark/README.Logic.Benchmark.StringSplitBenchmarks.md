```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **801.0 ns** |  **27.46 ns** |  **1.51 ns** |    **799.3 ns** |    **802.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,469.6 ns | 127.23 ns |  6.97 ns |  1,461.6 ns |  1,474.5 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,025.6 ns** | **227.16 ns** | **12.45 ns** |  **8,014.1 ns** |  **8,038.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,398.3 ns | 143.54 ns |  7.87 ns | 14,391.0 ns | 14,406.6 ns | 0.3815 |   32080 B |
