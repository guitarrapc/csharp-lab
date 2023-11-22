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
|                                     Method | Number |        Mean |        Error |     StdDev |         Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **90.29 ns** |     **1.826 ns** |   **0.100 ns** |    **90.21 ns** |     **90.40 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |   117.91 ns |    14.478 ns |   0.794 ns |   117.04 ns |    118.60 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    98.10 ns |    11.707 ns |   0.642 ns |    97.62 ns |     98.83 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    20.79 ns |     1.249 ns |   0.068 ns |    20.75 ns |     20.87 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    19.24 ns |     0.461 ns |   0.025 ns |    19.22 ns |     19.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    17.07 ns |     0.419 ns |   0.023 ns |    17.04 ns |     17.09 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **915.19 ns** |   **161.725 ns** |   **8.865 ns** |   **909.91 ns** |    **925.43 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   937.87 ns |    35.551 ns |   1.949 ns |   936.31 ns |    940.05 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 | 1,002.64 ns |   258.305 ns |  14.159 ns |   989.59 ns |  1,017.69 ns | 0.0095 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   211.99 ns |     0.977 ns |   0.054 ns |   211.93 ns |    212.03 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   188.82 ns |    15.920 ns |   0.873 ns |   188.22 ns |    189.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   167.01 ns |     4.054 ns |   0.222 ns |   166.76 ns |    167.18 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **9,026.07 ns** |   **550.136 ns** |  **30.155 ns** | **9,003.44 ns** |  **9,060.30 ns** | **0.0916** |   **8,800 B** |
|                            LogWithIfParams |    100 | 9,345.19 ns |   476.569 ns |  26.122 ns | 9,315.23 ns |  9,363.17 ns | 0.0916 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 9,975.72 ns | 2,034.616 ns | 111.524 ns | 9,885.97 ns | 10,100.58 ns | 0.0916 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,064.81 ns |    17.844 ns |   0.978 ns | 2,063.68 ns |  2,065.44 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,916.25 ns |   973.519 ns |  53.362 ns | 1,873.76 ns |  1,976.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,665.65 ns |    25.797 ns |   1.414 ns | 1,664.46 ns |  1,667.21 ns |      - |         - |
