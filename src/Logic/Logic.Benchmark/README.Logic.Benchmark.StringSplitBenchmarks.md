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
| **StringSplitNoAlloc** | **1**      |    **840.8 ns** |   **4.91 ns** |  **0.27 ns** |    **840.4 ns** |    **841.0 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,506.9 ns |  44.05 ns |  2.41 ns |  1,504.3 ns |  1,509.2 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,408.1 ns** | **494.95 ns** | **27.13 ns** |  **8,383.1 ns** |  **8,436.9 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,024.7 ns | 543.33 ns | 29.78 ns | 14,990.4 ns | 15,044.7 ns | 0.3815 |   32080 B |
