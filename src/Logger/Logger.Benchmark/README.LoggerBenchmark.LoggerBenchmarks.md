```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.01 ns** |     **2.858 ns** |  **0.157 ns** |    **59.89 ns** |    **60.19 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.50 ns |     1.176 ns |  0.064 ns |    59.44 ns |    59.56 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.39 ns |     2.031 ns |  0.111 ns |    65.27 ns |    65.49 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.79 ns |     0.401 ns |  0.022 ns |    19.77 ns |    19.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.64 ns |     0.299 ns |  0.016 ns |    19.63 ns |    19.66 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    20.52 ns |    43.317 ns |  2.374 ns |    19.13 ns |    23.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **626.45 ns** |   **542.219 ns** | **29.721 ns** |   **608.61 ns** |   **660.76 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   596.60 ns |    27.252 ns |  1.494 ns |   594.89 ns |   597.62 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   654.25 ns |    20.890 ns |  1.145 ns |   653.24 ns |   655.49 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.10 ns |     1.400 ns |  0.077 ns |   198.03 ns |   198.18 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.31 ns |     5.928 ns |  0.325 ns |   196.98 ns |   197.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.11 ns |    32.589 ns |  1.786 ns |   192.09 ns |   195.49 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,007.59 ns** |   **241.029 ns** | **13.212 ns** | **5,995.72 ns** | **6,021.82 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,932.12 ns | 1,717.671 ns | 94.151 ns | 5,865.07 ns | 6,039.76 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 7,980.79 ns |   358.279 ns | 19.638 ns | 7,969.17 ns | 8,003.46 ns | 0.0916 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,987.39 ns |    20.898 ns |  1.145 ns | 1,986.45 ns | 1,988.67 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,004.39 ns |   314.693 ns | 17.249 ns | 1,993.79 ns | 2,024.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,919.44 ns |    13.516 ns |  0.741 ns | 1,918.94 ns | 1,920.30 ns |      - |         - |
