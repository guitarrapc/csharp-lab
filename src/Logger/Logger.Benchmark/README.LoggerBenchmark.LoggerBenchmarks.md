```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.41 ns** |   **1.152 ns** |  **0.063 ns** |    **61.34 ns** |    **61.46 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.24 ns |   2.562 ns |  0.140 ns |    59.08 ns |    59.34 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.50 ns |   2.415 ns |  0.132 ns |    65.35 ns |    65.58 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    21.33 ns |   7.785 ns |  0.427 ns |    20.99 ns |    21.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.70 ns |   0.835 ns |  0.046 ns |    19.64 ns |    19.73 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.36 ns |   5.019 ns |  0.275 ns |    19.21 ns |    19.68 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.71 ns** |  **24.120 ns** |  **1.322 ns** |   **609.54 ns** |   **612.15 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   603.50 ns |  38.626 ns |  2.117 ns |   601.36 ns |   605.59 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   674.47 ns |   8.069 ns |  0.442 ns |   673.97 ns |   674.83 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.22 ns |  11.958 ns |  0.655 ns |   198.50 ns |   199.79 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.21 ns |   5.633 ns |  0.309 ns |   196.93 ns |   197.54 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.94 ns |  74.360 ns |  4.076 ns |   191.53 ns |   198.65 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,049.86 ns** | **126.607 ns** |  **6.940 ns** | **6,045.40 ns** | **6,057.85 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,932.48 ns |  94.650 ns |  5.188 ns | 5,926.49 ns | 5,935.73 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,605.60 ns |  66.871 ns |  3.665 ns | 6,601.56 ns | 6,608.71 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,000.85 ns | 102.104 ns |  5.597 ns | 1,994.50 ns | 2,005.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,003.62 ns | 576.768 ns | 31.615 ns | 1,983.01 ns | 2,040.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,922.46 ns |   9.112 ns |  0.499 ns | 1,921.90 ns | 1,922.87 ns |      - |         - |
