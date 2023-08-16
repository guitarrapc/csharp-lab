# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |         Mean |      Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **127.84 ns** |   **6.915 ns** |  **0.379 ns** |    **127.57 ns** |    **128.27 ns** | **0.0033** |      **88 B** |
|                            LogWithIfParams |      1 |    129.18 ns |   9.673 ns |  0.530 ns |    128.84 ns |    129.79 ns | 0.0033 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    136.70 ns |   7.667 ns |  0.420 ns |    136.34 ns |    137.16 ns | 0.0033 |      88 B |
|                   LogDefineWithoutIfParams |      1 |     27.24 ns |   0.350 ns |  0.019 ns |     27.22 ns |     27.26 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |     27.17 ns |   2.850 ns |  0.156 ns |     27.00 ns |     27.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |     21.40 ns |   3.154 ns |  0.173 ns |     21.28 ns |     21.60 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |  **1,275.70 ns** | **131.743 ns** |  **7.221 ns** |  **1,267.69 ns** |  **1,281.71 ns** | **0.0343** |     **880 B** |
|                            LogWithIfParams |     10 |  1,311.95 ns |  54.531 ns |  2.989 ns |  1,308.50 ns |  1,313.74 ns | 0.0343 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |  1,344.30 ns |  39.174 ns |  2.147 ns |  1,342.23 ns |  1,346.52 ns | 0.0343 |     880 B |
|                   LogDefineWithoutIfParams |     10 |    296.12 ns |  21.414 ns |  1.174 ns |    295.22 ns |    297.45 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |    265.05 ns |  26.108 ns |  1.431 ns |    263.89 ns |    266.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |    209.13 ns |   3.391 ns |  0.186 ns |    208.92 ns |    209.29 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **12,533.24 ns** | **195.142 ns** | **10.696 ns** | **12,521.34 ns** | **12,542.07 ns** | **0.3357** |   **8,800 B** |
|                            LogWithIfParams |    100 | 13,019.36 ns | 238.080 ns | 13.050 ns | 13,007.65 ns | 13,033.43 ns | 0.3357 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 13,604.22 ns | 380.845 ns | 20.875 ns | 13,586.05 ns | 13,627.02 ns | 0.3357 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 |  2,838.75 ns |  49.434 ns |  2.710 ns |  2,835.64 ns |  2,840.54 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 |  2,512.53 ns | 198.647 ns | 10.888 ns |  2,499.96 ns |  2,519.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 |  2,120.81 ns | 172.474 ns |  9.454 ns |  2,109.89 ns |  2,126.33 ns |      - |         - |
