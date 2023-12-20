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
|                         **LogWithoutIfParams** |      **1** |    **63.31 ns** |   **4.587 ns** |  **0.251 ns** |    **63.14 ns** |    **63.60 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    62.37 ns |  22.723 ns |  1.246 ns |    61.59 ns |    63.81 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    67.31 ns |   2.347 ns |  0.129 ns |    67.17 ns |    67.43 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.46 ns |   0.401 ns |  0.022 ns |    21.43 ns |    21.47 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.36 ns |   0.435 ns |  0.024 ns |    21.34 ns |    21.39 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.91 ns |   2.581 ns |  0.141 ns |    19.82 ns |    20.07 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **606.25 ns** |  **10.118 ns** |  **0.555 ns** |   **605.61 ns** |   **606.60 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   613.78 ns |  12.886 ns |  0.706 ns |   613.22 ns |   614.57 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   669.25 ns |  17.508 ns |  0.960 ns |   668.48 ns |   670.33 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   208.90 ns |   1.055 ns |  0.058 ns |   208.85 ns |   208.96 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   208.58 ns |   1.460 ns |  0.080 ns |   208.51 ns |   208.67 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   194.49 ns |  18.359 ns |  1.006 ns |   193.33 ns |   195.12 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,189.03 ns** | **421.969 ns** | **23.130 ns** | **6,162.68 ns** | **6,206.00 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,028.95 ns | 148.032 ns |  8.114 ns | 6,021.33 ns | 6,037.48 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,614.95 ns |  86.711 ns |  4.753 ns | 6,610.29 ns | 6,619.79 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,026.29 ns | 188.784 ns | 10.348 ns | 2,014.34 ns | 2,032.36 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,996.17 ns | 160.102 ns |  8.776 ns | 1,987.75 ns | 2,005.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,957.06 ns | 566.983 ns | 31.078 ns | 1,936.63 ns | 1,992.83 ns |      - |         - |
