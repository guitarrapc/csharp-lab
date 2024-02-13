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
| **LogWithoutIfParams**                         | **1**      |    **61.38 ns** |   **1.037 ns** |  **0.057 ns** |    **61.33 ns** |    **61.44 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.88 ns |   1.409 ns |  0.077 ns |    60.80 ns |    60.96 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.40 ns |   0.478 ns |  0.026 ns |    65.37 ns |    65.42 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.88 ns |   2.584 ns |  0.142 ns |    19.80 ns |    20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.88 ns |   0.070 ns |  0.004 ns |    19.88 ns |    19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.34 ns |   6.167 ns |  0.338 ns |    19.12 ns |    19.73 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **612.45 ns** |  **35.917 ns** |  **1.969 ns** |   **611.09 ns** |   **614.71 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   606.71 ns |   6.904 ns |  0.378 ns |   606.33 ns |   607.09 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   682.11 ns |   7.953 ns |  0.436 ns |   681.70 ns |   682.57 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   200.10 ns |  24.322 ns |  1.333 ns |   199.09 ns |   201.62 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   198.54 ns |  41.596 ns |  2.280 ns |   197.04 ns |   201.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.98 ns |  21.136 ns |  1.159 ns |   192.00 ns |   194.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,128.52 ns** | **224.918 ns** | **12.329 ns** | **6,116.28 ns** | **6,140.94 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,209.25 ns |  37.965 ns |  2.081 ns | 6,207.10 ns | 6,211.26 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,533.11 ns |  17.453 ns |  0.957 ns | 6,532.36 ns | 6,534.19 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,984.75 ns |   8.676 ns |  0.476 ns | 1,984.46 ns | 1,985.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.50 ns |  24.951 ns |  1.368 ns | 1,981.67 ns | 1,984.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,927.01 ns |  17.409 ns |  0.954 ns | 1,926.06 ns | 1,927.97 ns |      - |         - |
