# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **138.62 ns** |     **2.974 ns** |  **0.163 ns** |    **138.51 ns** |    **138.80 ns** | **0.0045** |      **88 B** |
|                            LogWithIfParams |      1 |    142.33 ns |    13.742 ns |  0.753 ns |    141.77 ns |    143.19 ns | 0.0045 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    161.72 ns |     0.853 ns |  0.047 ns |    161.66 ns |    161.75 ns | 0.0045 |      88 B |
|                   LogDefineWithoutIfParams |      1 |     35.21 ns |     0.897 ns |  0.049 ns |     35.16 ns |     35.26 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |     32.35 ns |     1.603 ns |  0.088 ns |     32.30 ns |     32.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |     26.35 ns |     0.362 ns |  0.020 ns |     26.34 ns |     26.38 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |  **1,390.09 ns** |    **50.550 ns** |  **2.771 ns** |  **1,387.16 ns** |  **1,392.66 ns** | **0.0458** |     **880 B** |
|                            LogWithIfParams |     10 |  1,430.94 ns |    50.302 ns |  2.757 ns |  1,428.05 ns |  1,433.54 ns | 0.0458 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |  1,556.70 ns |    39.691 ns |  2.176 ns |  1,554.20 ns |  1,558.17 ns | 0.0458 |     880 B |
|                   LogDefineWithoutIfParams |     10 |    355.71 ns |     0.557 ns |  0.031 ns |    355.68 ns |    355.74 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |    328.22 ns |     0.865 ns |  0.047 ns |    328.17 ns |    328.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |    272.85 ns |    25.703 ns |  1.409 ns |    272.00 ns |    274.48 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **13,809.42 ns** | **1,006.070 ns** | **55.146 ns** | **13,758.26 ns** | **13,867.84 ns** | **0.4578** |   **8,800 B** |
|                            LogWithIfParams |    100 | 14,411.41 ns |   891.262 ns | 48.853 ns | 14,377.82 ns | 14,467.45 ns | 0.4578 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 15,611.15 ns |   440.304 ns | 24.135 ns | 15,583.35 ns | 15,626.75 ns | 0.4578 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 |  3,463.83 ns |   120.094 ns |  6.583 ns |  3,460.01 ns |  3,471.44 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 |  3,190.71 ns |    13.586 ns |  0.745 ns |  3,190.04 ns |  3,191.51 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 |  2,625.59 ns |    12.262 ns |  0.672 ns |  2,624.91 ns |  2,626.26 ns |      - |         - |
