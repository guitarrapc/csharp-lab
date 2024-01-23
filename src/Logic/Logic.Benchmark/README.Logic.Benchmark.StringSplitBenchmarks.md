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
| **StringSplitNoAlloc** | **1**      |    **884.0 ns** |  **58.46 ns** |  **3.20 ns** |    **880.3 ns** |    **886.3 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,498.9 ns |  70.38 ns |  3.86 ns |  1,496.2 ns |  1,503.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,387.6 ns** | **795.64 ns** | **43.61 ns** |  **8,354.9 ns** |  **8,437.1 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,113.8 ns | 738.52 ns | 40.48 ns | 15,067.1 ns | 15,139.3 ns | 0.3815 |   32080 B |
