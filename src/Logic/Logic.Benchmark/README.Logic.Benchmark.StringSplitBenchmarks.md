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
| **StringSplitNoAlloc** | **1**      |    **842.1 ns** |    **41.38 ns** |  **2.27 ns** |    **839.9 ns** |    **844.4 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,510.4 ns |   225.37 ns | 12.35 ns |  1,502.7 ns |  1,524.6 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,421.5 ns** |   **636.89 ns** | **34.91 ns** |  **8,386.7 ns** |  **8,456.5 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,619.5 ns | 1,181.20 ns | 64.75 ns | 14,580.1 ns | 14,694.2 ns | 0.3815 |   32080 B |
