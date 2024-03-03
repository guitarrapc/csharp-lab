```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.28 ns** |     **2.337 ns** |  **0.128 ns** |    **60.13 ns** |    **60.37 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    61.05 ns |    45.257 ns |  2.481 ns |    59.48 ns |    63.91 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.68 ns |     3.994 ns |  0.219 ns |    65.46 ns |    65.89 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.90 ns |     2.398 ns |  0.131 ns |    19.82 ns |    20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.97 ns |     4.007 ns |  0.220 ns |    19.83 ns |    20.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.24 ns |     0.604 ns |  0.033 ns |    19.20 ns |    19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.50 ns** |    **28.448 ns** |  **1.559 ns** |   **608.84 ns** |   **611.94 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   607.89 ns |    42.260 ns |  2.316 ns |   606.04 ns |   610.48 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   675.80 ns |    63.628 ns |  3.488 ns |   671.79 ns |   678.14 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   206.08 ns |     6.274 ns |  0.344 ns |   205.86 ns |   206.48 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.58 ns |     1.857 ns |  0.102 ns |   197.49 ns |   197.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.99 ns |    17.070 ns |  0.936 ns |   192.37 ns |   194.07 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,073.20 ns** | **1,234.270 ns** | **67.655 ns** | **6,033.50 ns** | **6,151.32 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,595.98 ns | 1,300.196 ns | 71.268 ns | 6,550.72 ns | 6,678.13 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,551.71 ns |   856.303 ns | 46.937 ns | 6,523.25 ns | 6,605.89 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,998.78 ns |   287.208 ns | 15.743 ns | 1,984.77 ns | 2,015.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,001.89 ns |   358.341 ns | 19.642 ns | 1,986.52 ns | 2,024.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,930.49 ns |   113.038 ns |  6.196 ns | 1,926.80 ns | 1,937.64 ns |      - |         - |
