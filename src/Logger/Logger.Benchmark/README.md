# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **178.47 ns** |    **32.752 ns** |   **1.795 ns** |    **177.09 ns** |    **180.50 ns** | **0.0033** |      **88 B** |
|                            LogWithIfParams |      1 |    183.60 ns |    58.114 ns |   3.185 ns |    180.63 ns |    186.96 ns | 0.0033 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    191.44 ns |    32.594 ns |   1.787 ns |    189.38 ns |    192.57 ns | 0.0033 |      88 B |
|                   LogDefineWithoutIfParams |      1 |     44.40 ns |     2.057 ns |   0.113 ns |     44.28 ns |     44.51 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |     39.46 ns |    12.372 ns |   0.678 ns |     38.97 ns |     40.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |     33.15 ns |     8.752 ns |   0.480 ns |     32.83 ns |     33.70 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |  **1,755.00 ns** |   **391.730 ns** |  **21.472 ns** |  **1,734.85 ns** |  **1,777.59 ns** | **0.0324** |     **880 B** |
|                            LogWithIfParams |     10 |  1,797.41 ns |   315.889 ns |  17.315 ns |  1,782.63 ns |  1,816.46 ns | 0.0324 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |  2,003.11 ns | 1,187.032 ns |  65.065 ns |  1,934.98 ns |  2,064.60 ns | 0.0324 |     880 B |
|                   LogDefineWithoutIfParams |     10 |    429.40 ns |    52.265 ns |   2.865 ns |    427.31 ns |    432.66 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |    395.41 ns |   193.309 ns |  10.596 ns |    385.65 ns |    406.68 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |    336.43 ns |    16.516 ns |   0.905 ns |    335.41 ns |    337.14 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **17,326.29 ns** | **5,115.971 ns** | **280.424 ns** | **17,005.19 ns** | **17,522.98 ns** | **0.3357** |   **8,800 B** |
|                            LogWithIfParams |    100 | 18,639.21 ns | 7,477.242 ns | 409.853 ns | 18,211.58 ns | 19,028.60 ns | 0.3357 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 19,089.18 ns | 5,356.696 ns | 293.619 ns | 18,841.97 ns | 19,413.73 ns | 0.3357 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 |  4,369.22 ns |   177.002 ns |   9.702 ns |  4,358.07 ns |  4,375.71 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 |  3,953.23 ns | 1,234.609 ns |  67.673 ns |  3,883.25 ns |  4,018.33 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 |  3,354.53 ns | 1,199.419 ns |  65.744 ns |  3,303.39 ns |  3,428.69 ns |      - |         - |
