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
|      **Stopwatch** |      **1** |    **61.69 ns** |  **7.938 ns** | **0.435 ns** |    **61.39 ns** |    **62.19 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.60 ns |  0.082 ns | 0.004 ns |    56.59 ns |    56.60 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.67 ns** | **12.975 ns** | **0.711 ns** |   **317.85 ns** |   **319.14 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   310.07 ns |  2.949 ns | 0.162 ns |   309.94 ns |   310.25 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,887.68 ns** | **78.598 ns** | **4.308 ns** | **2,883.47 ns** | **2,892.08 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,841.94 ns |  2.663 ns | 0.146 ns | 2,841.78 ns | 2,842.07 ns |      - |         - |
