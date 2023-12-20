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
|      **Stopwatch** |      **1** |    **61.67 ns** |  **3.203 ns** | **0.176 ns** |    **61.52 ns** |    **61.86 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.56 ns |  0.270 ns | 0.015 ns |    56.55 ns |    56.57 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.62 ns** | **22.386 ns** | **1.227 ns** |   **317.86 ns** |   **320.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.90 ns |  0.756 ns | 0.041 ns |   309.86 ns |   309.95 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,887.49 ns** | **89.616 ns** | **4.912 ns** | **2,883.43 ns** | **2,892.95 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.86 ns |  1.801 ns | 0.099 ns | 2,842.79 ns | 2,842.97 ns |      - |         - |
