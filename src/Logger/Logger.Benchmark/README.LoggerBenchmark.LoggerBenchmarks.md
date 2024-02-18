```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **59.78 ns** |   **2.719 ns** |  **0.149 ns** |    **59.61 ns** |    **59.89 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.98 ns |   5.025 ns |  0.275 ns |    58.75 ns |    59.29 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.64 ns |  10.444 ns |  0.572 ns |    67.03 ns |    68.16 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.87 ns |   2.473 ns |  0.136 ns |    19.79 ns |    20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    20.02 ns |   0.919 ns |  0.050 ns |    19.97 ns |    20.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.41 ns |   8.333 ns |  0.457 ns |    19.13 ns |    19.94 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **604.01 ns** |  **43.590 ns** |  **2.389 ns** |   **602.53 ns** |   **606.77 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   596.52 ns |  11.133 ns |  0.610 ns |   595.90 ns |   597.12 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   741.65 ns |  47.912 ns |  2.626 ns |   739.00 ns |   744.25 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.32 ns |   9.527 ns |  0.522 ns |   198.02 ns |   198.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.34 ns |   1.409 ns |  0.077 ns |   197.26 ns |   197.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.48 ns |  14.855 ns |  0.814 ns |   191.74 ns |   193.35 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **5,975.22 ns** | **153.669 ns** |  **8.423 ns** | **5,967.81 ns** | **5,984.39 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,881.22 ns | 210.439 ns | 11.535 ns | 5,874.38 ns | 5,894.54 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,726.85 ns | 374.727 ns | 20.540 ns | 6,706.02 ns | 6,747.09 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,989.01 ns |  71.759 ns |  3.933 ns | 1,986.54 ns | 1,993.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,015.21 ns | 567.215 ns | 31.091 ns | 1,989.63 ns | 2,049.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,924.93 ns |  53.683 ns |  2.943 ns | 1,921.93 ns | 1,927.81 ns |      - |         - |
