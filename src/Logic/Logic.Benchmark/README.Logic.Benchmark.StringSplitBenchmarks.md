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
| **StringSplitNoAlloc** | **1**      |    **797.4 ns** |   **8.45 ns** |  **0.46 ns** |    **797.1 ns** |    **798.0 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,503.9 ns |  89.04 ns |  4.88 ns |  1,499.0 ns |  1,508.8 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,035.0 ns** |  **80.30 ns** |  **4.40 ns** |  **8,031.5 ns** |  **8,040.0 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,751.5 ns | 900.98 ns | 49.39 ns | 14,694.6 ns | 14,782.8 ns | 0.3815 |   32080 B |
