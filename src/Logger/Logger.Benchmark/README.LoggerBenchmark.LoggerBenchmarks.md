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
|                         **LogWithoutIfParams** |      **1** |    **63.19 ns** |   **6.261 ns** |  **0.343 ns** |    **62.86 ns** |    **63.54 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    61.94 ns |   0.267 ns |  0.015 ns |    61.92 ns |    61.95 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    71.05 ns |  16.434 ns |  0.901 ns |    70.04 ns |    71.78 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.62 ns |   3.163 ns |  0.173 ns |    21.46 ns |    21.80 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.41 ns |   1.393 ns |  0.076 ns |    21.34 ns |    21.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.91 ns |   1.354 ns |  0.074 ns |    19.84 ns |    19.99 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **652.78 ns** |  **33.530 ns** |  **1.838 ns** |   **650.66 ns** |   **653.97 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   625.15 ns |  39.333 ns |  2.156 ns |   623.62 ns |   627.62 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   670.68 ns |  66.150 ns |  3.626 ns |   667.38 ns |   674.56 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.59 ns |  11.666 ns |  0.639 ns |   208.89 ns |   210.15 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   208.38 ns |   8.106 ns |  0.444 ns |   208.08 ns |   208.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   195.20 ns |   8.136 ns |  0.446 ns |   194.89 ns |   195.71 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **5,997.43 ns** |  **60.095 ns** |  **3.294 ns** | **5,993.81 ns** | **6,000.25 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,201.92 ns | 373.019 ns | 20.446 ns | 6,189.12 ns | 6,225.50 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,661.92 ns | 251.947 ns | 13.810 ns | 6,646.35 ns | 6,672.71 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,035.46 ns |  59.069 ns |  3.238 ns | 2,031.80 ns | 2,037.95 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 2,005.14 ns | 153.113 ns |  8.393 ns | 1,995.45 ns | 2,010.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,941.41 ns | 151.507 ns |  8.305 ns | 1,931.86 ns | 1,946.94 ns |      - |         - |
