# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **93.11 ns** |  **37.502 ns** |  **2.056 ns** |    **91.76 ns** |    **95.48 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    97.62 ns |   0.656 ns |  0.036 ns |    97.58 ns |    97.65 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    99.46 ns |   3.564 ns |  0.195 ns |    99.25 ns |    99.64 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    20.80 ns |   0.177 ns |  0.010 ns |    20.79 ns |    20.81 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    19.28 ns |   1.326 ns |  0.073 ns |    19.22 ns |    19.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    16.96 ns |   2.393 ns |  0.131 ns |    16.89 ns |    17.12 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **913.01 ns** |  **21.542 ns** |  **1.181 ns** |   **911.70 ns** |   **914.00 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   944.49 ns |  17.939 ns |  0.983 ns |   943.86 ns |   945.63 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 | 1,025.08 ns |  22.179 ns |  1.216 ns | 1,023.84 ns | 1,026.27 ns | 0.0095 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   212.35 ns |  11.247 ns |  0.616 ns |   211.95 ns |   213.06 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   187.18 ns |   7.031 ns |  0.385 ns |   186.92 ns |   187.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   166.04 ns |   2.646 ns |  0.145 ns |   165.92 ns |   166.20 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **9,072.02 ns** | **448.676 ns** | **24.593 ns** | **9,048.31 ns** | **9,097.41 ns** | **0.0916** |   **8,800 B** |
|                            LogWithIfParams |    100 | 9,353.35 ns | 269.393 ns | 14.766 ns | 9,341.58 ns | 9,369.92 ns | 0.0916 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 9,863.42 ns | 484.901 ns | 26.579 ns | 9,843.37 ns | 9,893.57 ns | 0.0916 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,131.00 ns | 176.881 ns |  9.695 ns | 2,123.57 ns | 2,141.97 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,893.25 ns | 275.916 ns | 15.124 ns | 1,883.90 ns | 1,910.70 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,666.22 ns |  41.874 ns |  2.295 ns | 1,664.22 ns | 1,668.73 ns |      - |         - |
