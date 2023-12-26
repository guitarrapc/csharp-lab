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
| **LogWithoutIfParams**                         | **1**      |    **60.94 ns** |   **2.350 ns** |  **0.129 ns** |    **60.79 ns** |    **61.03 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.96 ns |   1.387 ns |  0.076 ns |    60.88 ns |    61.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.97 ns |   2.832 ns |  0.155 ns |    65.79 ns |    66.08 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.02 ns |   4.596 ns |  0.252 ns |    19.85 ns |    20.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.84 ns |   0.815 ns |  0.045 ns |    19.81 ns |    19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.24 ns |   0.520 ns |  0.029 ns |    19.22 ns |    19.28 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **611.55 ns** |  **17.713 ns** |  **0.971 ns** |   **610.43 ns** |   **612.20 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   633.58 ns |  14.772 ns |  0.810 ns |   632.64 ns |   634.08 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.86 ns |  38.063 ns |  2.086 ns |   658.33 ns |   662.24 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.78 ns |   6.539 ns |  0.358 ns |   198.57 ns |   199.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.14 ns |   5.501 ns |  0.302 ns |   196.96 ns |   197.49 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.77 ns |  11.727 ns |  0.643 ns |   192.15 ns |   193.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,025.30 ns** | **232.054 ns** | **12.720 ns** | **6,013.46 ns** | **6,038.74 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,073.35 ns | 162.731 ns |  8.920 ns | 6,063.29 ns | 6,080.27 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,509.16 ns | 578.685 ns | 31.720 ns | 6,476.15 ns | 6,539.40 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,988.71 ns |  94.108 ns |  5.158 ns | 1,985.69 ns | 1,994.66 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,987.72 ns |  36.362 ns |  1.993 ns | 1,985.78 ns | 1,989.77 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,922.26 ns |  20.430 ns |  1.120 ns | 1,921.17 ns | 1,923.41 ns |      - |         - |
