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
| **StringSplitNoAlloc** | **1**      |    **801.7 ns** |    **15.51 ns** |  **0.85 ns** |    **801.0 ns** |    **802.6 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,439.4 ns |    87.83 ns |  4.81 ns |  1,433.9 ns |  1,442.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,361.5 ns** |   **199.25 ns** | **10.92 ns** |  **8,351.3 ns** |  **8,373.0 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,738.4 ns | 1,171.01 ns | 64.19 ns | 14,669.1 ns | 14,795.9 ns | 0.3815 |   32080 B |
