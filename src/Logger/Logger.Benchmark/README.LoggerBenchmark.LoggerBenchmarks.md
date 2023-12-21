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
|                         **LogWithoutIfParams** |      **1** |    **64.00 ns** |   **1.512 ns** |  **0.083 ns** |    **63.92 ns** |    **64.08 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    63.77 ns |   1.367 ns |  0.075 ns |    63.71 ns |    63.86 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    68.14 ns |   3.725 ns |  0.204 ns |    67.95 ns |    68.36 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.48 ns |   0.637 ns |  0.035 ns |    21.45 ns |    21.52 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.32 ns |   0.427 ns |  0.023 ns |    21.30 ns |    21.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    20.32 ns |   9.096 ns |  0.499 ns |    19.85 ns |    20.84 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **612.49 ns** |  **13.752 ns** |  **0.754 ns** |   **611.63 ns** |   **613.05 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   627.30 ns |  22.501 ns |  1.233 ns |   625.88 ns |   628.08 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   683.88 ns | 183.831 ns | 10.076 ns |   674.86 ns |   694.76 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.26 ns |  10.061 ns |  0.551 ns |   208.91 ns |   209.89 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   209.84 ns |  39.933 ns |  2.189 ns |   208.50 ns |   212.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   194.56 ns |  10.321 ns |  0.566 ns |   194.10 ns |   195.19 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,085.14 ns** | **119.987 ns** |  **6.577 ns** | **6,078.15 ns** | **6,091.20 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,202.08 ns | 147.342 ns |  8.076 ns | 6,194.14 ns | 6,210.28 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,917.45 ns |  87.863 ns |  4.816 ns | 6,911.89 ns | 6,920.34 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,022.64 ns | 139.780 ns |  7.662 ns | 2,014.40 ns | 2,029.55 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 2,002.44 ns | 126.850 ns |  6.953 ns | 1,995.04 ns | 2,008.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,929.94 ns |  92.856 ns |  5.090 ns | 1,926.51 ns | 1,935.79 ns |      - |         - |
