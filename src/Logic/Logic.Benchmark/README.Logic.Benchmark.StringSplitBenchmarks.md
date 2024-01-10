```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **800.2 ns** |    **22.21 ns** |  **1.22 ns** |    **798.8 ns** |    **801.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,502.9 ns |   108.24 ns |  5.93 ns |  1,497.7 ns |  1,509.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,017.4 ns** |   **119.32 ns** |  **6.54 ns** |  **8,012.9 ns** |  **8,024.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,048.1 ns | 1,105.83 ns | 60.61 ns | 14,979.4 ns | 15,094.0 ns | 0.3815 |   32080 B |
