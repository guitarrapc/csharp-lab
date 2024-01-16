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
| **StringSplitNoAlloc** | **1**      |    **799.8 ns** |   **9.72 ns** |  **0.53 ns** |    **799.5 ns** |    **800.4 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,464.0 ns | 116.29 ns |  6.37 ns |  1,458.3 ns |  1,470.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,017.4 ns** | **357.26 ns** | **19.58 ns** |  **8,003.4 ns** |  **8,039.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,951.3 ns | 431.20 ns | 23.64 ns | 14,925.3 ns | 14,971.4 ns | 0.3815 |   32080 B |
