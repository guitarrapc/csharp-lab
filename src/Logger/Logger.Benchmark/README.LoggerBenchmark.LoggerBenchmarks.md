```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.73 ns** |    **20.515 ns** |   **1.125 ns** |    **60.94 ns** |    **63.02 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.25 ns |     1.919 ns |   0.105 ns |    59.15 ns |    59.36 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.21 ns |     7.942 ns |   0.435 ns |    66.72 ns |    67.54 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.16 ns |     0.198 ns |   0.011 ns |    20.14 ns |    20.16 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    20.03 ns |     6.975 ns |   0.382 ns |    19.80 ns |    20.47 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.48 ns |     5.892 ns |   0.323 ns |    19.14 ns |    19.79 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **612.97 ns** |    **16.127 ns** |   **0.884 ns** |   **612.09 ns** |   **613.86 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   607.89 ns |    59.297 ns |   3.250 ns |   604.59 ns |   611.09 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   708.14 ns |    88.489 ns |   4.850 ns |   704.80 ns |   713.70 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.24 ns |     4.691 ns |   0.257 ns |   199.01 ns |   199.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   199.98 ns |    41.532 ns |   2.276 ns |   197.48 ns |   201.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.86 ns |    10.731 ns |   0.588 ns |   191.46 ns |   192.54 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,092.17 ns** |   **335.745 ns** |  **18.403 ns** | **6,072.71 ns** | **6,109.29 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,119.29 ns | 1,802.283 ns |  98.789 ns | 6,005.48 ns | 6,182.94 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,902.21 ns | 2,582.995 ns | 141.583 ns | 6,746.38 ns | 7,022.95 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,989.38 ns |    90.734 ns |   4.973 ns | 1,985.45 ns | 1,994.97 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.93 ns |    91.715 ns |   5.027 ns | 1,982.35 ns | 1,992.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,927.48 ns |    95.306 ns |   5.224 ns | 1,922.95 ns | 1,933.19 ns |      - |         - |
