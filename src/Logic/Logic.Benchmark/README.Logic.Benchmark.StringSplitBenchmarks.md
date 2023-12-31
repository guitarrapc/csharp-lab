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
| **StringSplitNoAlloc** | **1**      |    **834.8 ns** |  **31.63 ns** |  **1.73 ns** |    **833.6 ns** |    **836.8 ns** |      **-** |         **-** |
| StringSplit        | 1      |  1,455.1 ns |  50.71 ns |  2.78 ns |  1,453.0 ns |  1,458.3 ns | 0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |  **8,033.4 ns** | **308.22 ns** | **16.89 ns** |  **8,022.0 ns** |  **8,052.8 ns** |      **-** |         **-** |
| StringSplit        | 10     | 15,030.0 ns | 558.72 ns | 30.63 ns | 15,000.8 ns | 15,061.8 ns | 0.3815 |   32080 B |
