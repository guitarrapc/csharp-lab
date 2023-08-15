# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **166.40 ns** |    **23.681 ns** |   **1.298 ns** |    **165.03 ns** |    **167.61 ns** | **0.0045** |      **88 B** |
|                            LogWithIfParams |      1 |    176.85 ns |    21.536 ns |   1.180 ns |    175.70 ns |    178.06 ns | 0.0045 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    182.56 ns |    34.867 ns |   1.911 ns |    180.39 ns |    183.97 ns | 0.0045 |      88 B |
|                   LogDefineWithoutIfParams |      1 |     40.95 ns |    13.224 ns |   0.725 ns |     40.46 ns |     41.78 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |     38.67 ns |    29.219 ns |   1.602 ns |     37.01 ns |     40.20 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |     31.00 ns |     8.863 ns |   0.486 ns |     30.57 ns |     31.53 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |  **1,646.18 ns** | **1,058.941 ns** |  **58.044 ns** |  **1,579.48 ns** |  **1,685.23 ns** | **0.0458** |     **880 B** |
|                            LogWithIfParams |     10 |  1,683.68 ns |   343.847 ns |  18.847 ns |  1,669.74 ns |  1,705.12 ns | 0.0458 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |  1,764.27 ns |   553.566 ns |  30.343 ns |  1,746.74 ns |  1,799.30 ns | 0.0458 |     880 B |
|                   LogDefineWithoutIfParams |     10 |    419.01 ns |   198.078 ns |  10.857 ns |    406.81 ns |    427.61 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |    381.08 ns |   242.882 ns |  13.313 ns |    370.90 ns |    396.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |    325.07 ns |    59.793 ns |   3.277 ns |    321.28 ns |    326.98 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **16,343.29 ns** | **3,995.663 ns** | **219.016 ns** | **16,094.52 ns** | **16,507.08 ns** | **0.4578** |   **8,800 B** |
|                            LogWithIfParams |    100 | 17,949.60 ns | 2,399.314 ns | 131.515 ns | 17,837.78 ns | 18,094.50 ns | 0.4578 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 17,346.34 ns | 4,141.116 ns | 226.989 ns | 17,096.67 ns | 17,540.26 ns | 0.4578 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 |  4,152.77 ns |   849.741 ns |  46.577 ns |  4,106.55 ns |  4,199.69 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 |  3,822.37 ns |   993.912 ns |  54.480 ns |  3,761.11 ns |  3,865.40 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 |  2,902.96 ns | 1,905.643 ns | 104.455 ns |  2,795.93 ns |  3,004.64 ns |      - |         - |
