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
| **StringSplitNoAlloc** | **1**      |    **834.5 ns** |  **15.66 ns** |  **0.86 ns** |    **833.9 ns** |    **835.5 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,496.3 ns | 104.45 ns |  5.73 ns |  1,490.9 ns |  1,502.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,353.9 ns** | **206.65 ns** | **11.33 ns** |  **8,340.9 ns** |  **8,361.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,897.5 ns | 977.79 ns | 53.60 ns | 15,835.7 ns | 15,931.2 ns | 0.3662 |   32080 B |
