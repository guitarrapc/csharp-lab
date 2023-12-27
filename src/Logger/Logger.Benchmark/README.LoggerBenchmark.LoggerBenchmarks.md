```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **62.51 ns** |  **25.682 ns** |  **1.408 ns** |    **61.60 ns** |    **64.13 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    62.41 ns |  23.394 ns |  1.282 ns |    60.93 ns |    63.26 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.48 ns |  26.343 ns |  1.444 ns |    65.51 ns |    68.14 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.80 ns |   0.457 ns |  0.025 ns |    19.78 ns |    19.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.96 ns |   0.858 ns |  0.047 ns |    19.92 ns |    20.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.21 ns |   1.000 ns |  0.055 ns |    19.15 ns |    19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **605.61 ns** |  **24.230 ns** |  **1.328 ns** |   **604.42 ns** |   **607.04 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   612.48 ns | 183.340 ns | 10.049 ns |   605.73 ns |   624.03 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   675.83 ns | 312.452 ns | 17.127 ns |   665.69 ns |   695.61 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.81 ns |  23.494 ns |  1.288 ns |   197.94 ns |   200.29 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.71 ns |  14.496 ns |  0.795 ns |   197.25 ns |   198.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.21 ns |  18.228 ns |  0.999 ns |   193.44 ns |   195.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,317.87 ns** | **326.860 ns** | **17.916 ns** | **6,302.86 ns** | **6,337.71 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,998.59 ns | 174.575 ns |  9.569 ns | 5,988.85 ns | 6,007.97 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,540.87 ns | 230.645 ns | 12.642 ns | 6,531.15 ns | 6,555.16 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,994.82 ns | 145.002 ns |  7.948 ns | 1,986.44 ns | 2,002.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.93 ns |  70.369 ns |  3.857 ns | 1,979.95 ns | 1,987.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,933.08 ns |  71.414 ns |  3.914 ns | 1,930.18 ns | 1,937.53 ns |      - |         - |
