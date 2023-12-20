``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **64.77 ns** |   **3.711 ns** |  **0.203 ns** |    **64.58 ns** |    **64.99 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    62.37 ns |   0.166 ns |  0.009 ns |    62.36 ns |    62.38 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    68.96 ns |  22.290 ns |  1.222 ns |    67.82 ns |    70.25 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.62 ns |   3.451 ns |  0.189 ns |    21.49 ns |    21.84 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.51 ns |   0.524 ns |  0.029 ns |    21.48 ns |    21.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.96 ns |   4.698 ns |  0.258 ns |    19.79 ns |    20.26 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **614.66 ns** |  **27.803 ns** |  **1.524 ns** |   **613.18 ns** |   **616.22 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   622.63 ns | 279.803 ns | 15.337 ns |   613.08 ns |   640.32 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   688.67 ns |  40.075 ns |  2.197 ns |   686.37 ns |   690.75 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   208.88 ns |   0.679 ns |  0.037 ns |   208.85 ns |   208.92 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.17 ns |   3.104 ns |  0.170 ns |   209.06 ns |   209.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.40 ns |   2.958 ns |  0.162 ns |   193.30 ns |   193.58 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,105.94 ns** | **339.757 ns** | **18.623 ns** | **6,086.32 ns** | **6,123.38 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 7,066.69 ns |  29.818 ns |  1.634 ns | 7,064.80 ns | 7,067.72 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,633.66 ns | 972.899 ns | 53.328 ns | 6,578.76 ns | 6,685.26 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,014.29 ns |  64.441 ns |  3.532 ns | 2,012.08 ns | 2,018.36 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,989.84 ns |  98.907 ns |  5.421 ns | 1,985.06 ns | 1,995.73 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,951.25 ns | 535.608 ns | 29.358 ns | 1,934.00 ns | 1,985.15 ns |      - |         - |
