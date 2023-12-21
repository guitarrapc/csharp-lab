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
|      **Stopwatch** |      **1** |    **61.73 ns** |  **2.386 ns** | **0.131 ns** |    **61.61 ns** |    **61.87 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.56 ns |  0.272 ns | 0.015 ns |    56.55 ns |    56.57 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.49 ns** | **11.876 ns** | **0.651 ns** |   **317.98 ns** |   **319.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   310.42 ns | 17.159 ns | 0.941 ns |   309.67 ns |   311.48 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,886.01 ns** | **95.398 ns** | **5.229 ns** | **2,882.61 ns** | **2,892.03 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.29 ns | 14.433 ns | 0.791 ns | 2,841.80 ns | 2,843.20 ns |      - |         - |
