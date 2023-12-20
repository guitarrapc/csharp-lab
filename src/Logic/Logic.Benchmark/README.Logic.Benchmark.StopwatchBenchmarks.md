``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **60.25 ns** |  **0.929 ns** | **0.051 ns** |    **60.20 ns** |    **60.30 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.22 ns |  0.689 ns | 0.038 ns |    56.19 ns |    56.26 ns |      - |         - |
|      **Stopwatch** |     **10** |   **314.57 ns** |  **8.707 ns** | **0.477 ns** |   **314.27 ns** |   **315.12 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   312.19 ns | 12.000 ns | 0.658 ns |   311.72 ns |   312.94 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,853.02 ns** |  **7.674 ns** | **0.421 ns** | **2,852.75 ns** | **2,853.50 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,876.08 ns | 74.200 ns | 4.067 ns | 2,871.39 ns | 2,878.70 ns |      - |         - |
