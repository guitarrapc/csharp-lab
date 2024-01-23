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
| **LogWithoutIfParams**                         | **1**      |    **60.61 ns** |   **7.227 ns** |  **0.396 ns** |    **60.17 ns** |    **60.95 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.13 ns |   3.907 ns |  0.214 ns |    59.00 ns |    59.38 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.21 ns |   8.762 ns |  0.480 ns |    66.70 ns |    67.64 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.83 ns |   1.257 ns |  0.069 ns |    19.79 ns |    19.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.96 ns |   5.178 ns |  0.284 ns |    19.79 ns |    20.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.31 ns |   5.146 ns |  0.282 ns |    19.15 ns |    19.64 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **613.52 ns** | **116.380 ns** |  **6.379 ns** |   **607.76 ns** |   **620.38 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   632.14 ns | 628.784 ns | 34.466 ns |   611.99 ns |   671.94 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   658.86 ns |  52.235 ns |  2.863 ns |   656.05 ns |   661.78 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.02 ns |   0.695 ns |  0.038 ns |   197.98 ns |   198.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.80 ns |   9.706 ns |  0.532 ns |   197.24 ns |   198.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.58 ns |   3.564 ns |  0.195 ns |   194.41 ns |   194.79 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,033.46 ns** | **404.215 ns** | **22.156 ns** | **6,018.48 ns** | **6,058.91 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,036.24 ns | 416.073 ns | 22.806 ns | 6,009.93 ns | 6,050.25 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,497.04 ns | 325.262 ns | 17.829 ns | 6,482.23 ns | 6,516.83 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,010.29 ns |  80.078 ns |  4.389 ns | 2,006.14 ns | 2,014.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,984.18 ns |  64.945 ns |  3.560 ns | 1,980.14 ns | 1,986.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,928.66 ns | 261.667 ns | 14.343 ns | 1,919.95 ns | 1,945.22 ns |      - |         - |
