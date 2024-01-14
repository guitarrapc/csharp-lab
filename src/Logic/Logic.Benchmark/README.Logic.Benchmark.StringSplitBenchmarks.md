```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **801.4 ns** |    **34.62 ns** |  **1.90 ns** |    **799.5 ns** |    **803.3 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,494.1 ns |    96.26 ns |  5.28 ns |  1,489.5 ns |  1,499.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,253.5 ns** |   **164.27 ns** |  **9.00 ns** |  **8,247.0 ns** |  **8,263.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,997.1 ns | 1,013.65 ns | 55.56 ns | 14,937.2 ns | 15,046.8 ns | 0.3815 |   32080 B |
