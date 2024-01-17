```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error        | StdDev      | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|-------------:|------------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **837.6 ns** |     **21.25 ns** |     **1.16 ns** |    **836.6 ns** |    **838.9 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,464.7 ns |     30.43 ns |     1.67 ns |  1,462.9 ns |  1,466.1 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,368.3 ns** |    **658.92 ns** |    **36.12 ns** |  **8,342.9 ns** |  **8,409.6 ns** |      **-** |         **-** |
| StringSplit        | 10     | 17,254.1 ns | 34,430.98 ns | 1,887.28 ns | 15,075.0 ns | 18,367.6 ns | 0.3815 |   32080 B |
