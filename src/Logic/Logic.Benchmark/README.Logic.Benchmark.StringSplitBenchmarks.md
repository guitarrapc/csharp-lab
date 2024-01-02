```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **803.6 ns** |  **29.86 ns** |  **1.64 ns** |    **802.1 ns** |    **805.3 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,471.0 ns |  73.50 ns |  4.03 ns |  1,467.3 ns |  1,475.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,031.5 ns** | **333.32 ns** | **18.27 ns** |  **8,015.8 ns** |  **8,051.6 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,292.7 ns | 609.03 ns | 33.38 ns | 15,257.6 ns | 15,324.1 ns | 0.3815 |   32080 B |
