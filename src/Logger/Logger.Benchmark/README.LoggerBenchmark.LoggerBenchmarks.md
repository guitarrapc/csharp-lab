```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **64.21 ns** |   **0.819 ns** | **0.045 ns** |    **64.16 ns** |    **64.24 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.90 ns |   2.279 ns | 0.125 ns |    58.80 ns |    59.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    69.18 ns |  33.499 ns | 1.836 ns |    68.01 ns |    71.30 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.78 ns |   0.618 ns | 0.034 ns |    19.76 ns |    19.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.85 ns |   1.818 ns | 0.100 ns |    19.79 ns |    19.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.29 ns |   1.013 ns | 0.056 ns |    19.23 ns |    19.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **694.39 ns** | **152.030 ns** | **8.333 ns** |   **687.85 ns** |   **703.78 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   624.94 ns |  21.421 ns | 1.174 ns |   623.64 ns |   625.92 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.94 ns |  20.677 ns | 1.133 ns |   658.76 ns |   661.02 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.24 ns |   7.983 ns | 0.438 ns |   197.91 ns |   198.73 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.30 ns |   1.853 ns | 0.102 ns |   197.19 ns |   197.39 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.28 ns |  25.565 ns | 1.401 ns |   191.45 ns |   193.90 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,035.15 ns** | **159.613 ns** | **8.749 ns** | **6,025.39 ns** | **6,042.29 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,990.20 ns | 134.515 ns | 7.373 ns | 5,983.98 ns | 5,998.35 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,539.67 ns |  84.994 ns | 4.659 ns | 6,534.35 ns | 6,543.03 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,000.37 ns |  92.064 ns | 5.046 ns | 1,996.63 ns | 2,006.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.43 ns | 131.850 ns | 7.227 ns | 1,981.82 ns | 1,994.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,924.35 ns |  22.323 ns | 1.224 ns | 1,923.50 ns | 1,925.75 ns |      - |         - |
