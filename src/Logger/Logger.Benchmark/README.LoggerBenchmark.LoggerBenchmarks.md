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
| **LogWithoutIfParams**                         | **1**      |    **60.21 ns** |   **2.535 ns** |  **0.139 ns** |    **60.06 ns** |    **60.33 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.76 ns |   2.158 ns |  0.118 ns |    58.62 ns |    58.84 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.19 ns |   4.319 ns |  0.237 ns |    65.04 ns |    65.47 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.02 ns |   4.163 ns |  0.228 ns |    19.78 ns |    20.24 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.77 ns |   0.352 ns |  0.019 ns |    19.76 ns |    19.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.29 ns |   2.560 ns |  0.140 ns |    19.18 ns |    19.44 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **603.83 ns** |  **12.852 ns** |  **0.704 ns** |   **603.02 ns** |   **604.25 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   606.89 ns |  15.871 ns |  0.870 ns |   605.93 ns |   607.63 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   673.88 ns | 112.470 ns |  6.165 ns |   669.73 ns |   680.96 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.90 ns |  18.724 ns |  1.026 ns |   197.96 ns |   199.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.34 ns |   5.502 ns |  0.302 ns |   197.14 ns |   197.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.34 ns |   3.915 ns |  0.215 ns |   192.12 ns |   192.54 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **5,986.82 ns** | **363.983 ns** | **19.951 ns** | **5,964.65 ns** | **6,003.33 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,889.59 ns | 445.254 ns | 24.406 ns | 5,866.13 ns | 5,914.84 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,669.40 ns |  40.057 ns |  2.196 ns | 6,667.25 ns | 6,671.64 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,986.15 ns |  11.475 ns |  0.629 ns | 1,985.60 ns | 1,986.84 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,993.94 ns | 295.330 ns | 16.188 ns | 1,981.81 ns | 2,012.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,938.18 ns | 115.281 ns |  6.319 ns | 1,933.59 ns | 1,945.38 ns |      - |         - |
