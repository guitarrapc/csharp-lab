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
| **StringSplitNoAlloc** | **1**      |    **835.8 ns** | **108.13 ns** |  **5.93 ns** |    **831.9 ns** |    **842.6 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,463.2 ns |  80.54 ns |  4.41 ns |  1,458.4 ns |  1,467.2 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,871.5 ns** |  **68.88 ns** |  **3.78 ns** |  **8,867.6 ns** |  **8,875.2 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,433.0 ns | 636.39 ns | 34.88 ns | 14,396.0 ns | 14,465.3 ns | 0.3815 |   32080 B |
