```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.87 ns** |     **2.593 ns** |   **0.142 ns** |    **61.73 ns** |    **62.01 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    63.52 ns |     1.587 ns |   0.087 ns |    63.42 ns |    63.58 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.34 ns |     3.159 ns |   0.173 ns |    66.14 ns |    66.47 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.81 ns |     0.415 ns |   0.023 ns |    19.79 ns |    19.83 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.89 ns |     5.389 ns |   0.295 ns |    19.69 ns |    20.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.11 ns |     0.090 ns |   0.005 ns |    19.11 ns |    19.12 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **694.64 ns** | **1,568.347 ns** |  **85.966 ns** |   **644.87 ns** |   **793.91 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   636.60 ns |   103.196 ns |   5.656 ns |   630.14 ns |   640.67 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   668.11 ns |    27.633 ns |   1.515 ns |   666.40 ns |   669.28 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.10 ns |     0.527 ns |   0.029 ns |   198.06 ns |   198.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.47 ns |     2.232 ns |   0.122 ns |   197.35 ns |   197.59 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.94 ns |    35.443 ns |   1.943 ns |   191.35 ns |   195.11 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,151.08 ns** |   **312.254 ns** |  **17.116 ns** | **6,139.81 ns** | **6,170.78 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,183.53 ns |   189.515 ns |  10.388 ns | 6,172.92 ns | 6,193.68 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,601.16 ns |    77.778 ns |   4.263 ns | 6,596.76 ns | 6,605.27 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,051.10 ns | 2,042.066 ns | 111.933 ns | 1,986.14 ns | 2,180.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,994.60 ns |   375.488 ns |  20.582 ns | 1,979.29 ns | 2,018.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,930.95 ns |   191.717 ns |  10.509 ns | 1,924.80 ns | 1,943.09 ns |      - |         - |
