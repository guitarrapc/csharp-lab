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
| **LogWithoutIfParams**                         | **1**      |    **65.16 ns** |     **6.048 ns** |  **0.332 ns** |    **64.80 ns** |    **65.46 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.95 ns |     1.757 ns |  0.096 ns |    59.85 ns |    60.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    68.11 ns |    34.124 ns |  1.870 ns |    66.89 ns |    70.26 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.92 ns |     2.670 ns |  0.146 ns |    19.80 ns |    20.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.89 ns |     1.427 ns |  0.078 ns |    19.82 ns |    19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.27 ns |     0.951 ns |  0.052 ns |    19.22 ns |    19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **622.99 ns** |   **265.097 ns** | **14.531 ns** |   **613.14 ns** |   **639.68 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   659.54 ns |    13.217 ns |  0.724 ns |   658.78 ns |   660.22 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   662.21 ns |    26.213 ns |  1.437 ns |   660.57 ns |   663.21 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.16 ns |     2.660 ns |  0.146 ns |   198.03 ns |   198.32 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.38 ns |     2.363 ns |  0.130 ns |   197.26 ns |   197.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.20 ns |    37.726 ns |  2.068 ns |   191.63 ns |   195.54 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,148.59 ns** |   **153.931 ns** |  **8.437 ns** | **6,141.22 ns** | **6,157.80 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,048.02 ns | 1,048.974 ns | 57.498 ns | 5,983.17 ns | 6,092.76 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,628.75 ns |    86.010 ns |  4.714 ns | 6,623.34 ns | 6,631.95 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,002.19 ns |   120.752 ns |  6.619 ns | 1,996.60 ns | 2,009.50 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.87 ns |    65.128 ns |  3.570 ns | 1,980.48 ns | 1,986.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,944.99 ns |   540.200 ns | 29.610 ns | 1,925.20 ns | 1,979.03 ns |      - |         - |
