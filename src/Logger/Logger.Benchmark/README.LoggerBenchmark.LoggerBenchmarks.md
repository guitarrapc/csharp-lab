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
| **LogWithoutIfParams**                         | **1**      |    **61.23 ns** |     **4.745 ns** |  **0.260 ns** |    **61.04 ns** |    **61.53 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.39 ns |     6.503 ns |  0.356 ns |    60.14 ns |    60.80 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.15 ns |     9.853 ns |  0.540 ns |    65.80 ns |    66.78 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.83 ns |     0.475 ns |  0.026 ns |    19.80 ns |    19.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.86 ns |     0.393 ns |  0.022 ns |    19.85 ns |    19.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.17 ns |     0.323 ns |  0.018 ns |    19.15 ns |    19.19 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **603.08 ns** |    **18.508 ns** |  **1.014 ns** |   **602.06 ns** |   **604.09 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   611.34 ns |    72.027 ns |  3.948 ns |   606.93 ns |   614.56 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.50 ns |    38.044 ns |  2.085 ns |   657.25 ns |   661.37 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.81 ns |    15.140 ns |  0.830 ns |   197.88 ns |   199.46 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.93 ns |     1.044 ns |  0.057 ns |   196.90 ns |   197.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.79 ns |     5.573 ns |  0.305 ns |   191.52 ns |   192.12 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,043.10 ns** |   **406.903 ns** | **22.304 ns** | **6,026.38 ns** | **6,068.42 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,936.03 ns |   209.221 ns | 11.468 ns | 5,926.28 ns | 5,948.66 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,579.41 ns | 1,760.282 ns | 96.487 ns | 6,517.78 ns | 6,690.60 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,996.90 ns |   156.338 ns |  8.569 ns | 1,988.00 ns | 2,005.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,004.90 ns |   734.517 ns | 40.261 ns | 1,981.10 ns | 2,051.38 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,923.89 ns |    53.833 ns |  2.951 ns | 1,921.63 ns | 1,927.23 ns |      - |         - |
