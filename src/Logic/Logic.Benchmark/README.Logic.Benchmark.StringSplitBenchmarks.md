```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **837.7 ns** |    **40.58 ns** |  **2.22 ns** |    **835.2 ns** |    **839.4 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,456.7 ns |   154.82 ns |  8.49 ns |  1,447.2 ns |  1,463.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,450.1 ns** |   **425.12 ns** | **23.30 ns** |  **8,435.0 ns** |  **8,476.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,530.0 ns | 1,380.31 ns | 75.66 ns | 14,458.0 ns | 14,608.9 ns | 0.3815 |   32080 B |
