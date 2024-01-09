```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **801.5 ns** |    **41.18 ns** |  **2.26 ns** |    **799.9 ns** |    **804.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,500.7 ns |   171.88 ns |  9.42 ns |  1,492.5 ns |  1,511.0 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,020.1 ns** |   **233.13 ns** | **12.78 ns** |  **8,009.9 ns** |  **8,034.4 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,552.1 ns | 1,093.97 ns | 59.96 ns | 14,514.3 ns | 14,621.2 ns | 0.3815 |   32080 B |
