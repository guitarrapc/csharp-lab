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
| **LogWithoutIfParams**                         | **1**      |    **63.83 ns** |   **1.810 ns** |  **0.099 ns** |    **63.72 ns** |    **63.91 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.41 ns |   3.322 ns |  0.182 ns |    59.28 ns |    59.62 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.74 ns |   4.476 ns |  0.245 ns |    65.59 ns |    66.03 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.95 ns |   3.104 ns |  0.170 ns |    19.83 ns |    20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.85 ns |   0.542 ns |  0.030 ns |    19.82 ns |    19.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.44 ns |   4.841 ns |  0.265 ns |    19.15 ns |    19.68 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **628.38 ns** | **584.022 ns** | **32.012 ns** |   **607.32 ns** |   **665.22 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   603.43 ns |  50.110 ns |  2.747 ns |   601.73 ns |   606.60 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   658.11 ns |   9.428 ns |  0.517 ns |   657.58 ns |   658.61 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.02 ns |   0.822 ns |  0.045 ns |   197.99 ns |   198.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   198.55 ns |  37.032 ns |  2.030 ns |   197.29 ns |   200.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.36 ns |   3.614 ns |  0.198 ns |   194.24 ns |   194.59 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,269.58 ns** | **123.895 ns** |  **6.791 ns** | **6,263.38 ns** | **6,276.84 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,853.60 ns | 275.511 ns | 15.102 ns | 5,838.52 ns | 5,868.73 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,800.32 ns | 213.136 ns | 11.683 ns | 6,787.19 ns | 6,809.55 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,988.95 ns |  87.926 ns |  4.820 ns | 1,985.55 ns | 1,994.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,012.75 ns | 711.443 ns | 38.997 ns | 1,985.95 ns | 2,057.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,930.80 ns | 121.345 ns |  6.651 ns | 1,924.88 ns | 1,937.99 ns |      - |         - |
