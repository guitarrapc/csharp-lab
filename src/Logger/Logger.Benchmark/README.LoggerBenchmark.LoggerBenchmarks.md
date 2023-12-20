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
|                         **LogWithoutIfParams** |      **1** |    **64.12 ns** |  **21.966 ns** |  **1.204 ns** |    **63.28 ns** |    **65.50 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    61.35 ns |   7.838 ns |  0.430 ns |    61.04 ns |    61.84 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    70.27 ns |  31.594 ns |  1.732 ns |    68.36 ns |    71.74 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.46 ns |   0.565 ns |  0.031 ns |    21.42 ns |    21.48 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.69 ns |   2.833 ns |  0.155 ns |    21.56 ns |    21.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.86 ns |   0.701 ns |  0.038 ns |    19.82 ns |    19.90 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **619.57 ns** |  **55.467 ns** |  **3.040 ns** |   **617.04 ns** |   **622.94 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   614.86 ns | 106.568 ns |  5.841 ns |   610.88 ns |   621.56 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   670.60 ns | 115.524 ns |  6.332 ns |   666.61 ns |   677.90 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.59 ns |   8.055 ns |  0.442 ns |   209.17 ns |   210.05 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.70 ns |   0.932 ns |  0.051 ns |   209.67 ns |   209.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   194.28 ns |  15.123 ns |  0.829 ns |   193.45 ns |   195.10 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **5,993.27 ns** | **315.537 ns** | **17.296 ns** | **5,981.14 ns** | **6,013.08 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,136.80 ns |  83.245 ns |  4.563 ns | 6,131.82 ns | 6,140.78 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,561.62 ns | 282.707 ns | 15.496 ns | 6,552.54 ns | 6,579.51 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,025.86 ns | 209.216 ns | 11.468 ns | 2,012.65 ns | 2,033.34 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,985.81 ns |  77.130 ns |  4.228 ns | 1,982.37 ns | 1,990.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,936.16 ns |  12.464 ns |  0.683 ns | 1,935.47 ns | 1,936.84 ns |      - |         - |
