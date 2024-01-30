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
| **StringSplitNoAlloc** | **1**      |    **840.4 ns** |    **21.17 ns** |  **1.16 ns** |    **839.5 ns** |    **841.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,467.2 ns |   162.59 ns |  8.91 ns |  1,460.6 ns |  1,477.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,420.5 ns** |   **320.69 ns** | **17.58 ns** |  **8,406.9 ns** |  **8,440.3 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,758.9 ns | 1,054.27 ns | 57.79 ns | 14,705.4 ns | 14,820.2 ns | 0.3815 |   32080 B |
