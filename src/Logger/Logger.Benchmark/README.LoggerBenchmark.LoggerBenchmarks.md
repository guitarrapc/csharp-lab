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
| **LogWithoutIfParams**                         | **1**      |    **61.22 ns** |   **1.536 ns** |  **0.084 ns** |    **61.15 ns** |    **61.31 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    61.59 ns |   1.086 ns |  0.060 ns |    61.52 ns |    61.64 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.56 ns |   3.115 ns |  0.171 ns |    65.41 ns |    65.75 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.92 ns |   2.972 ns |  0.163 ns |    19.80 ns |    20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.84 ns |   0.533 ns |  0.029 ns |    19.82 ns |    19.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.17 ns |   0.964 ns |  0.053 ns |    19.13 ns |    19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **611.09 ns** |  **42.389 ns** |  **2.323 ns** |   **609.63 ns** |   **613.77 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   613.90 ns |  90.629 ns |  4.968 ns |   610.84 ns |   619.63 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   660.71 ns |  52.992 ns |  2.905 ns |   657.46 ns |   663.06 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.75 ns |  31.077 ns |  1.703 ns |   198.69 ns |   201.71 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.33 ns |   6.203 ns |  0.340 ns |   197.06 ns |   197.71 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.56 ns |   5.240 ns |  0.287 ns |   192.30 ns |   192.87 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,104.35 ns** | **568.156 ns** | **31.143 ns** | **6,083.31 ns** | **6,140.13 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,968.43 ns |  60.216 ns |  3.301 ns | 5,964.99 ns | 5,971.57 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,609.46 ns | 192.327 ns | 10.542 ns | 6,598.65 ns | 6,619.71 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,990.67 ns |  75.857 ns |  4.158 ns | 1,987.24 ns | 1,995.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,984.87 ns |  51.419 ns |  2.818 ns | 1,981.86 ns | 1,987.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,930.96 ns |  11.199 ns |  0.614 ns | 1,930.46 ns | 1,931.65 ns |      - |         - |
