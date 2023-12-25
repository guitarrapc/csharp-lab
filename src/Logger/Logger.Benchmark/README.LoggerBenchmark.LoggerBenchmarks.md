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
|                         **LogWithoutIfParams** |      **1** |    **63.40 ns** |   **2.385 ns** |  **0.131 ns** |    **63.25 ns** |    **63.49 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    62.98 ns |  19.652 ns |  1.077 ns |    62.34 ns |    64.23 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    72.88 ns |  88.738 ns |  4.864 ns |    69.81 ns |    78.49 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.78 ns |   4.786 ns |  0.262 ns |    21.48 ns |    21.94 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.33 ns |   0.682 ns |  0.037 ns |    21.30 ns |    21.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    20.61 ns |  23.426 ns |  1.284 ns |    19.85 ns |    22.09 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **623.20 ns** |  **18.152 ns** |  **0.995 ns** |   **622.54 ns** |   **624.34 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   624.25 ns |  23.419 ns |  1.284 ns |   623.24 ns |   625.69 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   689.48 ns |  31.771 ns |  1.741 ns |   687.54 ns |   690.90 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   211.54 ns |  27.688 ns |  1.518 ns |   210.51 ns |   213.28 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.56 ns |   6.512 ns |  0.357 ns |   209.33 ns |   209.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.49 ns |   1.297 ns |  0.071 ns |   193.42 ns |   193.56 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,056.90 ns** | **246.274 ns** | **13.499 ns** | **6,047.08 ns** | **6,072.30 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,185.65 ns | 193.719 ns | 10.618 ns | 6,175.39 ns | 6,196.60 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,952.40 ns | 162.521 ns |  8.908 ns | 6,943.34 ns | 6,961.15 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,012.06 ns |   8.471 ns |  0.464 ns | 2,011.53 ns | 2,012.40 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 2,014.16 ns | 496.323 ns | 27.205 ns | 1,990.13 ns | 2,043.70 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,931.01 ns | 112.269 ns |  6.154 ns | 1,925.87 ns | 1,937.83 ns |      - |         - |
