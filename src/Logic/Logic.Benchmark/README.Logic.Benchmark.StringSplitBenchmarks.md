```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **833.6 ns** |    **18.54 ns** |   **1.02 ns** |    **832.5 ns** |    **834.5 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,509.4 ns |    54.09 ns |   2.97 ns |  1,506.0 ns |  1,511.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,023.9 ns** |   **173.83 ns** |   **9.53 ns** |  **8,014.4 ns** |  **8,033.4 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,578.0 ns | 2,814.36 ns | 154.26 ns | 14,445.9 ns | 14,747.5 ns | 0.3815 |   32080 B |
