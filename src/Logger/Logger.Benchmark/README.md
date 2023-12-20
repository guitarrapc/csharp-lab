# LoggerBenchmark.Benchmarks-report-github.md

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
|                         **LogWithoutIfParams** |      **1** |    **73.18 ns** |  **91.115 ns** |  **4.994 ns** |    **67.41 ns** |    **76.27 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    64.86 ns |  45.805 ns |  2.511 ns |    62.76 ns |    67.64 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    71.18 ns |  45.449 ns |  2.491 ns |    68.92 ns |    73.85 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.58 ns |   2.496 ns |  0.137 ns |    21.46 ns |    21.73 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.50 ns |   0.192 ns |  0.011 ns |    21.49 ns |    21.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    20.01 ns |   3.952 ns |  0.217 ns |    19.86 ns |    20.26 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **643.27 ns** |  **25.173 ns** |  **1.380 ns** |   **641.98 ns** |   **644.72 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   634.67 ns |  10.015 ns |  0.549 ns |   634.04 ns |   635.01 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   671.70 ns |  10.315 ns |  0.565 ns |   671.13 ns |   672.26 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.16 ns |   0.213 ns |  0.012 ns |   209.15 ns |   209.17 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   208.95 ns |   1.351 ns |  0.074 ns |   208.88 ns |   209.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.71 ns |   4.396 ns |  0.241 ns |   193.43 ns |   193.87 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,500.14 ns** | **395.278 ns** | **21.667 ns** | **6,485.30 ns** | **6,525.00 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,145.17 ns | 129.462 ns |  7.096 ns | 6,137.05 ns | 6,150.16 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,657.12 ns | 221.930 ns | 12.165 ns | 6,643.40 ns | 6,666.58 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,019.68 ns |  90.813 ns |  4.978 ns | 2,016.49 ns | 2,025.41 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,988.66 ns |  77.516 ns |  4.249 ns | 1,985.84 ns | 1,993.55 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,936.48 ns | 166.793 ns |  9.142 ns | 1,929.92 ns | 1,946.92 ns |      - |         - |
