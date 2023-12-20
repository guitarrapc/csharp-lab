``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |        Mean |        Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **64.13 ns** |     **0.788 ns** |  **0.043 ns** |    **64.09 ns** |    **64.17 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    64.59 ns |    40.009 ns |  2.193 ns |    63.30 ns |    67.12 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    69.69 ns |    53.975 ns |  2.959 ns |    67.63 ns |    73.08 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.55 ns |     2.116 ns |  0.116 ns |    21.48 ns |    21.68 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.58 ns |     0.485 ns |  0.027 ns |    21.56 ns |    21.61 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    20.07 ns |     5.615 ns |  0.308 ns |    19.83 ns |    20.42 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **613.34 ns** |    **15.030 ns** |  **0.824 ns** |   **612.50 ns** |   **614.15 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   610.27 ns |    19.519 ns |  1.070 ns |   609.52 ns |   611.49 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   665.02 ns |    47.797 ns |  2.620 ns |   662.39 ns |   667.63 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.30 ns |     3.917 ns |  0.215 ns |   209.08 ns |   209.51 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.94 ns |     9.035 ns |  0.495 ns |   209.51 ns |   210.48 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   261.60 ns | 1,084.178 ns | 59.427 ns |   192.98 ns |   296.01 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **5,972.53 ns** |   **274.097 ns** | **15.024 ns** | **5,955.64 ns** | **5,984.42 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,149.37 ns |   108.058 ns |  5.923 ns | 6,143.73 ns | 6,155.54 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,557.79 ns |   380.986 ns | 20.883 ns | 6,542.85 ns | 6,581.66 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,029.84 ns |    24.663 ns |  1.352 ns | 2,028.79 ns | 2,031.36 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 2,006.28 ns |   534.361 ns | 29.290 ns | 1,986.86 ns | 2,039.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,951.36 ns |   151.671 ns |  8.314 ns | 1,942.59 ns | 1,959.12 ns |      - |         - |
