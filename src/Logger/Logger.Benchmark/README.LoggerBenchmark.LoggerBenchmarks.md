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
| **LogWithoutIfParams**                         | **1**      |    **60.17 ns** |   **2.873 ns** |  **0.157 ns** |    **60.04 ns** |    **60.35 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.04 ns |   5.449 ns |  0.299 ns |    58.80 ns |    59.37 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.90 ns |  16.099 ns |  0.882 ns |    65.13 ns |    66.86 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.63 ns |   2.862 ns |  0.157 ns |    20.54 ns |    20.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.81 ns |   0.585 ns |  0.032 ns |    19.78 ns |    19.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.34 ns |   4.490 ns |  0.246 ns |    19.15 ns |    19.61 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.73 ns** |  **33.365 ns** |  **1.829 ns** |   **608.67 ns** |   **612.14 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   631.99 ns |  45.941 ns |  2.518 ns |   630.04 ns |   634.83 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   653.56 ns |  41.031 ns |  2.249 ns |   652.08 ns |   656.15 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.40 ns |   4.988 ns |  0.273 ns |   198.09 ns |   198.59 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.43 ns |  10.774 ns |  0.591 ns |   196.86 ns |   198.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.17 ns |   4.959 ns |  0.272 ns |   191.85 ns |   192.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,037.39 ns** | **106.817 ns** |  **5.855 ns** | **6,031.14 ns** | **6,042.75 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,938.63 ns | 858.282 ns | 47.045 ns | 5,899.69 ns | 5,990.90 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,613.74 ns | 643.624 ns | 35.279 ns | 6,577.06 ns | 6,647.42 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,988.65 ns |  93.526 ns |  5.126 ns | 1,985.39 ns | 1,994.56 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,988.67 ns |  78.674 ns |  4.312 ns | 1,985.09 ns | 1,993.46 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,928.53 ns |  42.373 ns |  2.323 ns | 1,926.68 ns | 1,931.13 ns |      - |         - |
