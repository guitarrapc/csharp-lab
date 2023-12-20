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
|                         **LogWithoutIfParams** |      **1** |    **64.18 ns** |   **2.239 ns** |  **0.123 ns** |    **64.04 ns** |    **64.27 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    63.84 ns |   6.847 ns |  0.375 ns |    63.40 ns |    64.07 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    70.36 ns |  24.657 ns |  1.352 ns |    68.97 ns |    71.67 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.56 ns |   2.491 ns |  0.137 ns |    21.45 ns |    21.71 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.62 ns |   0.027 ns |  0.001 ns |    21.62 ns |    21.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.84 ns |   0.972 ns |  0.053 ns |    19.78 ns |    19.89 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **673.44 ns** |  **44.277 ns** |  **2.427 ns** |   **671.38 ns** |   **676.12 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   612.92 ns |  83.903 ns |  4.599 ns |   609.24 ns |   618.08 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   695.79 ns |  11.489 ns |  0.630 ns |   695.30 ns |   696.50 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   208.87 ns |   1.110 ns |  0.061 ns |   208.81 ns |   208.92 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   208.85 ns |   2.283 ns |  0.125 ns |   208.73 ns |   208.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.99 ns |  14.727 ns |  0.807 ns |   193.37 ns |   194.90 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,030.53 ns** | **719.892 ns** | **39.460 ns** | **6,000.53 ns** | **6,075.23 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,013.19 ns | 439.263 ns | 24.078 ns | 5,989.38 ns | 6,037.53 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,584.93 ns | 152.443 ns |  8.356 ns | 6,575.42 ns | 6,591.08 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,034.06 ns | 649.165 ns | 35.583 ns | 2,010.90 ns | 2,075.03 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,991.08 ns |  94.983 ns |  5.206 ns | 1,985.29 ns | 1,995.38 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,934.74 ns | 124.652 ns |  6.833 ns | 1,926.90 ns | 1,939.44 ns |      - |         - |
