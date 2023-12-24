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
|                         **LogWithoutIfParams** |      **1** |    **65.07 ns** |  **34.985 ns** |  **1.918 ns** |    **63.71 ns** |    **67.27 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    62.46 ns |   6.324 ns |  0.347 ns |    62.20 ns |    62.86 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    70.04 ns |   2.672 ns |  0.146 ns |    69.87 ns |    70.15 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.44 ns |   0.256 ns |  0.014 ns |    21.43 ns |    21.46 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.31 ns |   0.311 ns |  0.017 ns |    21.29 ns |    21.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.83 ns |   0.531 ns |  0.029 ns |    19.80 ns |    19.86 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **625.08 ns** | **185.654 ns** | **10.176 ns** |   **617.37 ns** |   **636.61 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   626.57 ns |  12.099 ns |  0.663 ns |   625.82 ns |   627.08 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   675.53 ns |  46.372 ns |  2.542 ns |   673.63 ns |   678.42 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   208.92 ns |   4.572 ns |  0.251 ns |   208.76 ns |   209.21 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.37 ns |   3.002 ns |  0.165 ns |   209.18 ns |   209.47 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.95 ns |  18.272 ns |  1.002 ns |   193.33 ns |   195.11 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,158.33 ns** | **243.305 ns** | **13.336 ns** | **6,144.38 ns** | **6,170.96 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,201.08 ns |  25.012 ns |  1.371 ns | 6,199.72 ns | 6,202.46 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,827.33 ns | 356.063 ns | 19.517 ns | 6,815.89 ns | 6,849.87 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,013.64 ns |   4.834 ns |  0.265 ns | 2,013.46 ns | 2,013.94 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,993.67 ns |  13.566 ns |  0.744 ns | 1,992.81 ns | 1,994.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,933.08 ns |  18.093 ns |  0.992 ns | 1,932.30 ns | 1,934.19 ns |      - |         - |
