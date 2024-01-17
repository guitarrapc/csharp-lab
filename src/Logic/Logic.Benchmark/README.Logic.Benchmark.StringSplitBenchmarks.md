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
| **StringSplitNoAlloc** | **1**      |    **840.1 ns** |  **12.63 ns** |  **0.69 ns** |    **839.3 ns** |    **840.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,505.8 ns | 169.32 ns |  9.28 ns |  1,496.1 ns |  1,514.7 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,415.8 ns** | **238.33 ns** | **13.06 ns** |  **8,402.6 ns** |  **8,428.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,399.5 ns | 397.82 ns | 21.81 ns | 14,374.6 ns | 14,415.1 ns | 0.3815 |   32080 B |
