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
| **LogWithoutIfParams**                         | **1**      |    **60.55 ns** |     **5.177 ns** |   **0.284 ns** |    **60.23 ns** |    **60.74 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.13 ns |     3.680 ns |   0.202 ns |    58.98 ns |    59.36 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.69 ns |     2.073 ns |   0.114 ns |    66.57 ns |    66.80 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.94 ns |     7.259 ns |   0.398 ns |    20.58 ns |    21.37 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.89 ns |     0.200 ns |   0.011 ns |    19.88 ns |    19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.52 ns |     2.843 ns |   0.156 ns |    19.43 ns |    19.70 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **637.02 ns** |    **44.847 ns** |   **2.458 ns** |   **634.94 ns** |   **639.73 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   606.35 ns |    22.607 ns |   1.239 ns |   605.41 ns |   607.75 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   668.87 ns |     6.227 ns |   0.341 ns |   668.48 ns |   669.13 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.88 ns |     4.287 ns |   0.235 ns |   198.71 ns |   199.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   198.03 ns |     2.678 ns |   0.147 ns |   197.90 ns |   198.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.60 ns |    43.161 ns |   2.366 ns |   192.11 ns |   196.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,585.87 ns** | **4,356.468 ns** | **238.793 ns** | **6,441.33 ns** | **6,861.49 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,908.45 ns |   302.070 ns |  16.557 ns | 5,889.97 ns | 5,921.93 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,529.37 ns |   424.662 ns |  23.277 ns | 6,505.10 ns | 6,551.51 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,990.49 ns |   103.268 ns |   5.660 ns | 1,986.76 ns | 1,997.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,985.05 ns |    30.242 ns |   1.658 ns | 1,983.95 ns | 1,986.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 2,952.55 ns |    21.107 ns |   1.157 ns | 2,951.77 ns | 2,953.88 ns |      - |         - |
