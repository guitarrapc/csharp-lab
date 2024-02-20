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
| **LogWithoutIfParams**                         | **1**      |    **60.10 ns** |   **1.068 ns** |  **0.059 ns** |    **60.03 ns** |    **60.14 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.38 ns |   4.105 ns |  0.225 ns |    59.24 ns |    59.64 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.81 ns |   3.387 ns |  0.186 ns |    66.68 ns |    67.02 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.86 ns |   2.828 ns |  0.155 ns |    19.77 ns |    20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.85 ns |   1.252 ns |  0.069 ns |    19.81 ns |    19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.48 ns |   0.598 ns |  0.033 ns |    19.46 ns |    19.52 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **609.37 ns** |  **11.074 ns** |  **0.607 ns** |   **608.68 ns** |   **609.79 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   610.25 ns | 171.390 ns |  9.394 ns |   603.63 ns |   621.00 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   771.91 ns |  30.007 ns |  1.645 ns |   770.11 ns |   773.33 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.10 ns |   9.230 ns |  0.506 ns |   197.80 ns |   198.69 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.16 ns |   2.807 ns |  0.154 ns |   197.04 ns |   197.33 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.29 ns |   5.736 ns |  0.314 ns |   192.98 ns |   193.61 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,036.11 ns** |  **60.912 ns** |  **3.339 ns** | **6,033.23 ns** | **6,039.77 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,913.33 ns | 156.042 ns |  8.553 ns | 5,905.16 ns | 5,922.22 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,524.27 ns | 378.044 ns | 20.722 ns | 6,511.44 ns | 6,548.17 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,991.89 ns | 209.368 ns | 11.476 ns | 1,984.73 ns | 2,005.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,987.20 ns |  47.666 ns |  2.613 ns | 1,984.19 ns | 1,988.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,931.92 ns | 169.301 ns |  9.280 ns | 1,926.13 ns | 1,942.62 ns |      - |         - |
