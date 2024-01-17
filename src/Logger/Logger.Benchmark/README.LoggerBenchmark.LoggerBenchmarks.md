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
| **LogWithoutIfParams**                         | **1**      |    **60.18 ns** |   **5.527 ns** |  **0.303 ns** |    **59.88 ns** |    **60.49 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.36 ns |   4.170 ns |  0.229 ns |    59.12 ns |    59.57 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.95 ns |   4.388 ns |  0.240 ns |    65.71 ns |    66.19 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.08 ns |   4.457 ns |  0.244 ns |    19.81 ns |    20.29 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.90 ns |   0.577 ns |  0.032 ns |    19.88 ns |    19.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.43 ns |   7.565 ns |  0.415 ns |    19.15 ns |    19.91 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **608.53 ns** |  **47.638 ns** |  **2.611 ns** |   **607.01 ns** |   **611.54 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   598.68 ns |  25.584 ns |  1.402 ns |   597.40 ns |   600.17 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.14 ns |  52.613 ns |  2.884 ns |   655.91 ns |   661.46 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.69 ns |  36.170 ns |  1.983 ns |   198.08 ns |   201.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.99 ns |   0.805 ns |  0.044 ns |   196.94 ns |   197.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   196.72 ns |  33.869 ns |  1.856 ns |   195.50 ns |   198.85 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,068.05 ns** | **133.048 ns** |  **7.293 ns** | **6,059.93 ns** | **6,074.03 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,892.50 ns | 400.133 ns | 21.933 ns | 5,876.89 ns | 5,917.57 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,514.47 ns | 543.113 ns | 29.770 ns | 6,492.60 ns | 6,548.37 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,991.38 ns |  28.536 ns |  1.564 ns | 1,990.08 ns | 1,993.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,981.72 ns |   9.589 ns |  0.526 ns | 1,981.14 ns | 1,982.17 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,924.09 ns |  54.973 ns |  3.013 ns | 1,922.35 ns | 1,927.57 ns |      - |         - |
