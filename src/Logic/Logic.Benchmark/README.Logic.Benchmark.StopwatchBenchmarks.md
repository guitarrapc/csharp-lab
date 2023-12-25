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
|      **Stopwatch** |      **1** |    **61.59 ns** |  **3.530 ns** | **0.193 ns** |    **61.38 ns** |    **61.77 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.55 ns |  0.155 ns | 0.009 ns |    56.54 ns |    56.56 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.66 ns** | **20.266 ns** | **1.111 ns** |   **317.78 ns** |   **319.91 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.91 ns |  0.383 ns | 0.021 ns |   309.90 ns |   309.94 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,887.27 ns** | **88.977 ns** | **4.877 ns** | **2,883.81 ns** | **2,892.85 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,841.65 ns |  9.975 ns | 0.547 ns | 2,841.09 ns | 2,842.18 ns |      - |         - |
