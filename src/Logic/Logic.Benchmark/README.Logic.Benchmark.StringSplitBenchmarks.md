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
| **StringSplitNoAlloc** | **1**      |    **800.4 ns** |     **5.83 ns** |  **0.32 ns** |    **800.0 ns** |    **800.6 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,485.8 ns |    18.26 ns |  1.00 ns |  1,485.1 ns |  1,487.0 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,031.4 ns** |   **227.70 ns** | **12.48 ns** |  **8,022.8 ns** |  **8,045.7 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,443.7 ns | 1,645.04 ns | 90.17 ns | 15,347.1 ns | 15,525.7 ns | 0.3662 |   32080 B |
