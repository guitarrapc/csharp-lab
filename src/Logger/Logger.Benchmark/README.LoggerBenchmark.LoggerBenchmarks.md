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
| **LogWithoutIfParams**                         | **1**      |    **61.00 ns** |     **3.768 ns** |  **0.207 ns** |    **60.82 ns** |    **61.23 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    61.65 ns |    36.139 ns |  1.981 ns |    60.44 ns |    63.94 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.84 ns |     6.308 ns |  0.346 ns |    65.62 ns |    66.24 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.86 ns |     0.624 ns |  0.034 ns |    19.82 ns |    19.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.80 ns |     0.458 ns |  0.025 ns |    19.78 ns |    19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.33 ns |     3.517 ns |  0.193 ns |    19.21 ns |    19.55 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **616.29 ns** |     **7.167 ns** |  **0.393 ns** |   **615.91 ns** |   **616.69 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   628.24 ns |   199.801 ns | 10.952 ns |   621.89 ns |   640.89 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   661.93 ns |    11.675 ns |  0.640 ns |   661.25 ns |   662.52 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   197.92 ns |     1.647 ns |  0.090 ns |   197.82 ns |   197.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.56 ns |     8.342 ns |  0.457 ns |   197.29 ns |   198.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.78 ns |     0.938 ns |  0.051 ns |   191.72 ns |   191.81 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,085.57 ns** |   **171.023 ns** |  **9.374 ns** | **6,075.08 ns** | **6,093.15 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,968.42 ns |   148.818 ns |  8.157 ns | 5,959.59 ns | 5,975.68 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,613.61 ns | 1,365.503 ns | 74.848 ns | 6,527.55 ns | 6,663.53 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,006.25 ns |   214.202 ns | 11.741 ns | 1,995.52 ns | 2,018.79 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,984.23 ns |    24.255 ns |  1.330 ns | 1,982.71 ns | 1,985.15 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,930.00 ns |    93.319 ns |  5.115 ns | 1,924.88 ns | 1,935.11 ns |      - |         - |
