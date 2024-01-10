```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.00 ns** |     **4.672 ns** |  **0.256 ns** |    **59.85 ns** |    **60.30 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.15 ns |    10.169 ns |  0.557 ns |    59.66 ns |    60.75 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.77 ns |    55.593 ns |  3.047 ns |    65.52 ns |    71.24 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.87 ns |     2.801 ns |  0.154 ns |    19.78 ns |    20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.93 ns |     2.220 ns |  0.122 ns |    19.81 ns |    20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.47 ns |     0.294 ns |  0.016 ns |    19.45 ns |    19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **625.69 ns** |    **38.640 ns** |  **2.118 ns** |   **623.93 ns** |   **628.04 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   597.35 ns |    19.136 ns |  1.049 ns |   596.63 ns |   598.56 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   725.35 ns |    29.954 ns |  1.642 ns |   723.90 ns |   727.14 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   197.77 ns |     3.038 ns |  0.167 ns |   197.58 ns |   197.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.26 ns |     1.003 ns |  0.055 ns |   197.21 ns |   197.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.91 ns |     6.974 ns |  0.382 ns |   194.56 ns |   195.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,152.25 ns** | **1,219.402 ns** | **66.840 ns** | **6,101.94 ns** | **6,228.09 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,430.69 ns |   263.884 ns | 14.464 ns | 6,414.10 ns | 6,440.62 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,569.12 ns | 1,511.962 ns | 82.876 ns | 6,513.00 ns | 6,664.30 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,007.69 ns |   665.835 ns | 36.497 ns | 1,985.68 ns | 2,049.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,990.03 ns |    57.434 ns |  3.148 ns | 1,986.39 ns | 1,991.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,955.25 ns |   319.661 ns | 17.522 ns | 1,944.62 ns | 1,975.48 ns |      - |         - |
