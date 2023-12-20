``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.84 ns** |   **1.525 ns** |  **0.084 ns** |    **61.76 ns** |    **61.92 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.54 ns |   0.543 ns |  0.030 ns |    56.52 ns |    56.58 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.54 ns** |  **16.653 ns** |  **0.913 ns** |   **318.00 ns** |   **319.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.97 ns |   2.250 ns |  0.123 ns |   309.85 ns |   310.10 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,886.67 ns** |  **93.104 ns** |  **5.103 ns** | **2,883.72 ns** | **2,892.57 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,861.99 ns | 613.530 ns | 33.630 ns | 2,842.25 ns | 2,900.82 ns |      - |         - |
