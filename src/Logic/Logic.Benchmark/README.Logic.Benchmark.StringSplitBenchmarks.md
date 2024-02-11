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
| **StringSplitNoAlloc** | **1**      |    **841.1 ns** |   **7.99 ns** |  **0.44 ns** |    **840.6 ns** |    **841.4 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,465.0 ns |  34.27 ns |  1.88 ns |  1,463.1 ns |  1,466.9 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,332.6 ns** | **272.34 ns** | **14.93 ns** |  **8,316.9 ns** |  **8,346.6 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,524.2 ns | 873.51 ns | 47.88 ns | 14,496.2 ns | 14,579.5 ns | 0.3815 |   32080 B |
