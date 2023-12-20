``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.59 ns** |  **2.545 ns** | **0.139 ns** |    **61.51 ns** |    **61.75 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.59 ns |  0.692 ns | 0.038 ns |    56.54 ns |    56.62 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.55 ns** |  **7.581 ns** | **0.416 ns** |   **318.29 ns** |   **319.03 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   310.46 ns | 20.120 ns | 1.103 ns |   309.78 ns |   311.74 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,894.40 ns** | **24.655 ns** | **1.351 ns** | **2,892.99 ns** | **2,895.69 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,844.03 ns | 27.619 ns | 1.514 ns | 2,842.80 ns | 2,845.72 ns |      - |         - |
