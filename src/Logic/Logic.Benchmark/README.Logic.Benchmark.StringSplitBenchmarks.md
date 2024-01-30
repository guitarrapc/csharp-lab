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
| **StringSplitNoAlloc** | **1**      |    **840.1 ns** |  **19.53 ns** |  **1.07 ns** |    **838.9 ns** |    **841.0 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,502.7 ns |  79.44 ns |  4.35 ns |  1,497.7 ns |  1,505.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,427.4 ns** | **102.98 ns** |  **5.64 ns** |  **8,421.1 ns** |  **8,432.0 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,501.7 ns | 384.05 ns | 21.05 ns | 14,481.3 ns | 14,523.3 ns | 0.3662 |   32080 B |
