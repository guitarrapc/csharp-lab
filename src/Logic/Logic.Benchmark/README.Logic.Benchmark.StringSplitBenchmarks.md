```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **832.3 ns** |   **8.93 ns** |  **0.49 ns** |    **831.7 ns** |    **832.7 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,489.4 ns | 349.62 ns | 19.16 ns |  1,476.6 ns |  1,511.4 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,028.2 ns** | **281.67 ns** | **15.44 ns** |  **8,011.0 ns** |  **8,040.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,746.9 ns | 892.03 ns | 48.90 ns | 14,717.3 ns | 14,803.3 ns | 0.3815 |   32080 B |
