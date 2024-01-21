```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.18 ns** |     **1.097 ns** |   **0.060 ns** |    **61.14 ns** |    **61.25 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.90 ns |     2.458 ns |   0.135 ns |    59.79 ns |    60.05 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.12 ns |     2.533 ns |   0.139 ns |    64.97 ns |    65.24 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.95 ns |     1.784 ns |   0.098 ns |    19.89 ns |    20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.80 ns |     0.582 ns |   0.032 ns |    19.77 ns |    19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.39 ns |     3.526 ns |   0.193 ns |    19.18 ns |    19.55 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.09 ns** |    **19.981 ns** |   **1.095 ns** |   **609.42 ns** |   **611.35 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   615.07 ns |   148.679 ns |   8.150 ns |   605.72 ns |   620.71 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.22 ns |    19.117 ns |   1.048 ns |   658.28 ns |   660.35 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.90 ns |     6.966 ns |   0.382 ns |   198.46 ns |   199.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.79 ns |     8.910 ns |   0.488 ns |   197.48 ns |   198.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.01 ns |     3.178 ns |   0.174 ns |   191.85 ns |   192.19 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,043.70 ns** |   **233.169 ns** |  **12.781 ns** | **6,032.85 ns** | **6,057.78 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,340.30 ns | 5,205.371 ns | 285.324 ns | 6,011.05 ns | 6,515.22 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,553.02 ns | 1,350.284 ns |  74.014 ns | 6,506.20 ns | 6,638.34 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,988.63 ns |    99.397 ns |   5.448 ns | 1,985.45 ns | 1,994.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,983.76 ns |    37.549 ns |   2.058 ns | 1,981.50 ns | 1,985.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,939.13 ns |   514.189 ns |  28.184 ns | 1,919.79 ns | 1,971.47 ns |      - |         - |
