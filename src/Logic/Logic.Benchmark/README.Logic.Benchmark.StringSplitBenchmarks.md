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
| **StringSplitNoAlloc** | **1**      |    **801.1 ns** |  **12.86 ns** |  **0.70 ns** |    **800.3 ns** |    **801.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,442.3 ns |  93.48 ns |  5.12 ns |  1,439.0 ns |  1,448.2 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,019.2 ns** | **172.43 ns** |  **9.45 ns** |  **8,009.2 ns** |  **8,028.0 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,418.5 ns | 372.18 ns | 20.40 ns | 14,406.3 ns | 14,442.1 ns | 0.3815 |   32080 B |
