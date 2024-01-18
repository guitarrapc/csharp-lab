```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|---------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **839.6 ns** |     **7.95 ns** |  **0.44 ns** |    **839.2 ns** |    **840.1 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,470.1 ns |   127.61 ns |  6.99 ns |  1,464.6 ns |  1,478.0 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,351.4 ns** |   **226.24 ns** | **12.40 ns** |  **8,340.9 ns** |  **8,365.1 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,527.3 ns | 1,102.37 ns | 60.42 ns | 14,460.7 ns | 14,578.6 ns | 0.3815 |   32080 B |
