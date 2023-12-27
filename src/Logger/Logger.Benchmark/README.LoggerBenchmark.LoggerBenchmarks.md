```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.97 ns** |    **20.514 ns** |  **1.124 ns** |    **61.05 ns** |    **63.23 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    96.70 ns |     8.935 ns |  0.490 ns |    96.15 ns |    97.07 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.60 ns |     4.055 ns |  0.222 ns |    66.39 ns |    66.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.82 ns |     0.821 ns |  0.045 ns |    19.77 ns |    19.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.86 ns |     0.190 ns |  0.010 ns |    19.84 ns |    19.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.38 ns |     2.943 ns |  0.161 ns |    19.19 ns |    19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **627.72 ns** |    **54.529 ns** |  **2.989 ns** |   **624.93 ns** |   **630.87 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   657.95 ns |    22.603 ns |  1.239 ns |   657.19 ns |   659.38 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   664.91 ns |    21.523 ns |  1.180 ns |   663.95 ns |   666.23 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.25 ns |     5.577 ns |  0.306 ns |   199.03 ns |   199.60 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.40 ns |     2.012 ns |  0.110 ns |   197.31 ns |   197.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.71 ns |    23.434 ns |  1.284 ns |   191.74 ns |   194.16 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,135.81 ns** | **1,642.176 ns** | **90.013 ns** | **6,077.19 ns** | **6,239.45 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,966.88 ns |   211.829 ns | 11.611 ns | 5,953.68 ns | 5,975.53 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,538.71 ns |   351.857 ns | 19.286 ns | 6,526.84 ns | 6,560.97 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,989.26 ns |   128.647 ns |  7.052 ns | 1,984.56 ns | 1,997.37 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,980.26 ns |    12.236 ns |  0.671 ns | 1,979.49 ns | 1,980.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,929.24 ns |    98.859 ns |  5.419 ns | 1,922.98 ns | 1,932.45 ns |      - |         - |
