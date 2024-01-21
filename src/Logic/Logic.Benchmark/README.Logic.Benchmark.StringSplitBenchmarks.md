```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|-------:|----------:|
| **StringSplitNoAlloc** | **1**      |    **840.9 ns** |    **65.47 ns** |   **3.59 ns** |    **836.8 ns** |    **843.3 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,451.2 ns |   317.68 ns |  17.41 ns |  1,440.9 ns |  1,471.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,366.6 ns** |   **368.07 ns** |  **20.18 ns** |  **8,344.8 ns** |  **8,384.5 ns** |      **-** |         **-** |
| StringSplit        | 10     | 14,688.4 ns | 4,548.55 ns | 249.32 ns | 14,510.3 ns | 14,973.3 ns | 0.3815 |   32080 B |
