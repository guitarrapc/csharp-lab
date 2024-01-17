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
| **LogWithoutIfParams**                         | **1**      |    **60.16 ns** |   **0.409 ns** |  **0.022 ns** |    **60.14 ns** |    **60.18 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.41 ns |   4.549 ns |  0.249 ns |    59.23 ns |    59.69 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.68 ns |   3.324 ns |  0.182 ns |    65.56 ns |    65.89 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.53 ns |   1.868 ns |  0.102 ns |    20.41 ns |    20.60 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.85 ns |   0.474 ns |  0.026 ns |    19.82 ns |    19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.22 ns |   2.974 ns |  0.163 ns |    19.12 ns |    19.41 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **612.46 ns** |  **50.540 ns** |  **2.770 ns** |   **609.68 ns** |   **615.22 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   621.55 ns |  21.794 ns |  1.195 ns |   620.60 ns |   622.89 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   685.20 ns | 346.142 ns | 18.973 ns |   663.29 ns |   696.23 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.40 ns |   7.768 ns |  0.426 ns |   198.08 ns |   198.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.55 ns |  19.213 ns |  1.053 ns |   196.92 ns |   198.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.04 ns |  48.817 ns |  2.676 ns |   192.29 ns |   197.12 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,003.16 ns** | **329.080 ns** | **18.038 ns** | **5,990.16 ns** | **6,023.75 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,427.26 ns | 202.115 ns | 11.079 ns | 6,418.94 ns | 6,439.83 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,490.42 ns | 102.265 ns |  5.606 ns | 6,486.13 ns | 6,496.76 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,990.46 ns |  34.562 ns |  1.894 ns | 1,988.42 ns | 1,992.16 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,991.96 ns | 307.439 ns | 16.852 ns | 1,979.58 ns | 2,011.15 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,950.78 ns | 308.873 ns | 16.930 ns | 1,939.80 ns | 1,970.28 ns |      - |         - |
