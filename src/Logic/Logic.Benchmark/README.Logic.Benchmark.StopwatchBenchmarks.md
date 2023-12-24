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
|      **Stopwatch** |      **1** |    **61.64 ns** |  **3.625 ns** | **0.199 ns** |    **61.50 ns** |    **61.87 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.56 ns |  0.087 ns | 0.005 ns |    56.55 ns |    56.56 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.41 ns** |  **9.485 ns** | **0.520 ns** |   **317.81 ns** |   **318.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   310.69 ns | 19.425 ns | 1.065 ns |   310.02 ns |   311.92 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,888.23 ns** | **56.045 ns** | **3.072 ns** | **2,886.31 ns** | **2,891.78 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.63 ns |  7.767 ns | 0.426 ns | 2,842.25 ns | 2,843.09 ns |      - |         - |
