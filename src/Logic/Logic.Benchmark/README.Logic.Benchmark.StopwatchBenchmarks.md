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
|      **Stopwatch** |      **1** |    **61.57 ns** |  **3.335 ns** | **0.183 ns** |    **61.45 ns** |    **61.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.56 ns |  0.475 ns | 0.026 ns |    56.54 ns |    56.59 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.79 ns** | **23.294 ns** | **1.277 ns** |   **317.98 ns** |   **320.26 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.94 ns |  3.341 ns | 0.183 ns |   309.75 ns |   310.11 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,886.37 ns** | **85.147 ns** | **4.667 ns** | **2,883.49 ns** | **2,891.76 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.73 ns |  4.394 ns | 0.241 ns | 2,842.46 ns | 2,842.91 ns |      - |         - |
