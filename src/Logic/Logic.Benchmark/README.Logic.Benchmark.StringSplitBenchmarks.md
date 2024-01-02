```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **801.8 ns** |    **17.96 ns** |  **0.98 ns** |    **800.8 ns** |    **802.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,446.8 ns |    36.96 ns |  2.03 ns |  1,445.3 ns |  1,449.1 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,017.3 ns** |   **139.03 ns** |  **7.62 ns** |  **8,008.6 ns** |  **8,022.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,082.2 ns | 1,060.88 ns | 58.15 ns | 15,015.9 ns | 15,124.4 ns | 0.3815 |   32080 B |
