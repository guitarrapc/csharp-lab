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
|      **Stopwatch** |      **1** |    **61.85 ns** |  **4.141 ns** | **0.227 ns** |    **61.59 ns** |    **62.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.55 ns |  0.216 ns | 0.012 ns |    56.53 ns |    56.56 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.37 ns** |  **9.330 ns** | **0.511 ns** |   **317.98 ns** |   **318.95 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   312.36 ns | 77.469 ns | 4.246 ns |   309.84 ns |   317.26 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,887.57 ns** | **78.140 ns** | **4.283 ns** | **2,883.35 ns** | **2,891.91 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,844.27 ns | 65.123 ns | 3.570 ns | 2,842.19 ns | 2,848.39 ns |      - |         - |
