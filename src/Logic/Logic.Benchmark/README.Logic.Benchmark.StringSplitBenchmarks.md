```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **775.6 ns** |    **76.02 ns** |  **4.17 ns** |    **771.6 ns** |    **779.9 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,385.0 ns |   262.13 ns | 14.37 ns |  1,370.4 ns |  1,399.1 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **7,753.3 ns** |   **736.32 ns** | **40.36 ns** |  **7,706.7 ns** |  **7,777.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 13,500.6 ns | 1,811.87 ns | 99.31 ns | 13,404.0 ns | 13,602.4 ns | 0.3815 |   32080 B |
