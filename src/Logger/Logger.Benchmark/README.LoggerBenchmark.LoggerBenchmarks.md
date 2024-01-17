```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.00 ns** |   **3.780 ns** |  **0.207 ns** |    **59.79 ns** |    **60.21 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.48 ns |  23.065 ns |  1.264 ns |    59.74 ns |    61.94 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    70.06 ns |   6.668 ns |  0.365 ns |    69.81 ns |    70.48 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.12 ns |   4.229 ns |  0.232 ns |    19.91 ns |    20.37 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.83 ns |   0.639 ns |  0.035 ns |    19.80 ns |    19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.28 ns |   2.199 ns |  0.121 ns |    19.16 ns |    19.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **614.61 ns** | **120.662 ns** |  **6.614 ns** |   **607.21 ns** |   **619.93 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   621.89 ns | 143.919 ns |  7.889 ns |   612.83 ns |   627.25 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   664.09 ns |  18.106 ns |  0.992 ns |   663.41 ns |   665.23 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.17 ns |   0.358 ns |  0.020 ns |   198.15 ns |   198.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.35 ns |   7.250 ns |  0.397 ns |   196.97 ns |   197.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.00 ns |   8.116 ns |  0.445 ns |   191.49 ns |   192.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,092.02 ns** | **847.871 ns** | **46.475 ns** | **6,043.90 ns** | **6,136.66 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,933.01 ns | 140.483 ns |  7.700 ns | 5,925.90 ns | 5,941.19 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,528.53 ns | 363.819 ns | 19.942 ns | 6,508.97 ns | 6,548.84 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,984.92 ns |  13.121 ns |  0.719 ns | 1,984.12 ns | 1,985.51 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,997.95 ns | 369.110 ns | 20.232 ns | 1,985.92 ns | 2,021.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,931.89 ns |  32.402 ns |  1.776 ns | 1,930.63 ns | 1,933.92 ns |      - |         - |
